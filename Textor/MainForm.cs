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
                this.SuspendLayout();
                rtb.Undo();
                rtb.Redo();
                this.ResumeLayout();
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
            rtbMain.SaveFile(dlgSave.FileName);
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
            dlgColor.ShowDialog();
            rtbMain.SelectionColor = dlgColor.Color;
        }
    }
}
