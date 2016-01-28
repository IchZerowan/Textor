using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
