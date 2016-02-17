using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace Textor
{
    public partial class MainForm : Form
    {
        const string regKey = "Textor";
        const string path = "data.ini";
        string[] args;

        public MainForm(string[] args)
        {
            InitializeComponent();
            this.args = args;
            fontComboBox.Populate(true);
            fontComboBox.Text = rtbMain.Font.Name;
            rtbMain.Font = new Font(rtbMain.Text, 12);
        }

        private void Save()
        {
            if (dlgSave.FileName == "")
                dlgSave.ShowDialog();
            else
                rtbMain.SaveFile(dlgSave.FileName);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            rtbMain.Undo();
        }

        private void rtbMain_KeyUp(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                Font font = new Font(rtbMain.SelectionFont, rtbMain.SelectionFont.Style);
                this.SuspendLayout();
                rtb.Undo();
                rtb.Redo();
                this.ResumeLayout();
                rtbMain.SelectionFont = font;
            }
        }

        private void tsmiRedo_Click(object sender, EventArgs e)
        {
            rtbMain.Redo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            rtbMain.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            rtbMain.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            rtbMain.Paste();
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
        }

        private void tsmiBackground_Click(object sender, EventArgs e)
        {
            dlgColor.ShowDialog();
            rtbMain.BackColor = dlgColor.Color;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void dlgSave_FileOk(object sender, CancelEventArgs e)
        {
            if (dlgSave.FilterIndex == 1)
                rtbMain.SaveFile(dlgSave.FileName);
            else
                File.WriteAllLines(dlgSave.FileName, rtbMain.Lines);
            rtbMain.Modified = false;
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            dlgSave.ShowDialog();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
        }

        private void dlgOpen_FileOk(object sender, CancelEventArgs e)
        {
            rtbMain.LoadFile(dlgOpen.FileName);
            dlgSave.FileName = dlgOpen.FileName;
            rtbMain.Modified = false;
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbMain.SelectAll();
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if (rtbMain.Modified)
            {
                var res = MessageBox.Show("Сохранить изменения в файле?", "Внимание!", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Cancel)
                    return;
                else if (res == DialogResult.Yes)
                    Save();
            }
            dlgSave.FileName = "";
            dlgOpen.FileName = "";
            rtbMain.Clear();
            rtbMain.Modified = false;
        }

        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            {

                PrintDialog printDialog = new PrintDialog();
                PrintDocument documentToPrint = new PrintDocument();
                printDialog.Document = documentToPrint;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    StringReader reader = new StringReader(rtbMain.Text);
                    documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                    documentToPrint.Print();
                }
            }
        }

        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(rtbMain.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.rtbMain.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void tsmiDate_Click(object sender, EventArgs e)
        {
            Calendar.Visible = true;
            Calendar.Focus();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            rtbMain.AppendText(Calendar.SelectionStart.Date.ToShortDateString());
            Calendar.Visible = false;
        }

        private void tsmiCalendarClose_Click(object sender, EventArgs e)
        {
            Calendar.Visible = false;
        }

        private void tsmiDateToday_Click(object sender, EventArgs e)
        {
            Calendar.SetDate(DateTime.Now);
        }

        private void TsmiTimeNow_Click(object sender, EventArgs e)
        {
            rtbMain.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void mtbTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbMain.AppendText(mtbTime.Text);
                mtbTime.Visible = false;
            }
        }

        private void tsmiTimeOther_Click(object sender, EventArgs e)
        {
            mtbTime.Visible = true;
            mtbTime.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openReg();
            try
            {
                if (args.Length == 0) return;
                string path = args[0];
                string ext = getFileExtension(path).ToUpper();
                if (ext == "RTF")
                    rtbMain.LoadFile(path, RichTextBoxStreamType.RichText);
                else if (ext == "TXT")
                    rtbMain.Text = File.ReadAllText(path);
                else rtbMain.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
            finally
            {

            }
        }

        string getFileExtension(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void saveReg()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
                rk.SetValue("width", this.Size.Width);
                rk.SetValue("height", this.Size.Height);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        private void openReg()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKey);
                if (rk != null)
                {
                    this.Size = new Size((int)rk.GetValue("width"), (int)rk.GetValue("height"));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveReg();
        }

        private void tsmiFontColor_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionColor != null)
                dlgColor.Color = rtbMain.SelectionColor;
            dlgColor.ShowDialog();
            rtbMain.SelectionColor = dlgColor.Color;
        }

        private void tsmiBackColor_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionBackColor != null)
                dlgColor.Color = rtbMain.SelectionBackColor;
            dlgColor.ShowDialog();
            rtbMain.SelectionBackColor = dlgColor.Color;
        }

        private void tsmiTextFont_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                dlgFont.Font = rtbMain.SelectionFont;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                rtbMain.SelectionFont = dlgFont.Font;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            rtbMain.Height = this.Height - 85;
        }

        private void stbtnAlign_left_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionAlignment = HorizontalAlignment.Left;
            CheckAlign();
        }

        private void stbtnAlign_center_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionAlignment = HorizontalAlignment.Center;
            CheckAlign();
        }

        private void stbtnAlign_right_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionAlignment = HorizontalAlignment.Right;
            CheckAlign();
        }

        private void CheckAlign()
        {
            switch (rtbMain.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    {
                        stbtnAlign_left.Checked = true;
                        stbtnAlign_center.Checked = false;
                        stbtnAlign_right.Checked = false;
                        break;
                    }
                case HorizontalAlignment.Center:
                    {
                        stbtnAlign_left.Checked = false;
                        stbtnAlign_center.Checked = true;
                        stbtnAlign_right.Checked = false;
                        break;
                    }
                case HorizontalAlignment.Right:
                    {
                        stbtnAlign_left.Checked = false;
                        stbtnAlign_center.Checked = false;
                        stbtnAlign_right.Checked = true;
                        break;
                    }
                default:
                    {
                        stbtnAlign_left.Checked = false;
                        stbtnAlign_center.Checked = false;
                        stbtnAlign_right.Checked = false;
                        break;
                    }
            }
        }

        private void CheckFont()
        {
            tsbtnBold.Checked = false;
            tsbtnItalic.Checked = false;
            tsbtnUnderlined.Checked = false;
            if (rtbMain.SelectionFont.Bold)
                tsbtnBold.Checked = true;
            if (rtbMain.SelectionFont.Italic)
                tsbtnItalic.Checked = true;
            if (rtbMain.SelectionFont.Underline)
                tsbtnUnderlined.Checked = true;
        }

        private void rtbMain_SelectionChanged(object sender, EventArgs e)
        {
            CheckAlign();
            if (rtbMain.SelectionColor != null)
                themeColorPickerToolStripSplitButton.Color = rtbMain.SelectionColor;
            if (rtbMain.SelectionFont != null)
            {
                fontComboBox.Text = rtbMain.SelectionFont.Name;
                nudTextSize.Value = (decimal)rtbMain.SelectionFont.Size;
                CheckFont();
            }
        }

        private void themeColorPickerToolStripSplitButton_ButtonClick(object sender, EventArgs e)
        {
            rtbMain.SelectionColor = themeColorPickerToolStripSplitButton.Color;
        }

        private void themeColorPickerToolStripSplitButton_ColorSelected(object sender, ColorSelectedArg e)
        {
            rtbMain.SelectionColor = e.Color;
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = new Font(fontComboBox.Text, rtbMain.SelectionFont.Size);
        }

        private void nudTextSize_ValueChanged(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = new Font(rtbMain.SelectedText, (float)nudTextSize.Value);
        }

        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, !rtbMain.SelectionFont.Bold ? FontStyle.Bold | rtbMain.SelectionFont.Style : rtbMain.SelectionFont.Style & ~FontStyle.Bold);
            CheckFont();
        }

        private void tsbtnItalic_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, !rtbMain.SelectionFont.Italic ? FontStyle.Italic | rtbMain.SelectionFont.Style : rtbMain.SelectionFont.Style & ~FontStyle.Italic);
            CheckFont();
        }

        private void tsbtnUnderlined_Click(object sender, EventArgs e)
        {
            rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, !rtbMain.SelectionFont.Underline ? FontStyle.Underline | rtbMain.SelectionFont.Style : rtbMain.SelectionFont.Style & ~FontStyle.Underline);
            CheckFont();
        }
    }
}
