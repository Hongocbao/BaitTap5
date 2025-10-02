using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitTap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families)
            {
                cmbFornt.Items.Add(font.Name);
            }

            if (cmbFornt.Items.Contains("Tahoma"))
                cmbFornt.SelectedItem = "Tahoma";
            float[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (float size in fontSizes)
            {
                cmbSAI.Items.Add(size.ToString());
            }
            cmbSAI.SelectedItem = "8";

        }

        private void FontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDlg.Font;
                richTextBox1.ForeColor = fontDlg.Color;
            }
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            cmbFornt.Text = "tahoma";
            cmbSAI.Text = "8";
            richTextBox1.Font = new Font("tahoma", 8);
            richTextBox1.ForeColor = Color.Black;
        }
        private string currentFile = null;

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = saveFileDialog.FileName;
                    richTextBox1.SaveFile(currentFile);
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFile);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Bold)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Italic)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Italic;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Italic;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;
                if (richTextBox1.SelectionFont.Underline)
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void cmbFornt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                string selectedFont = cmbFornt.SelectedItem.ToString();
                float currentSize = richTextBox1.SelectionFont.Size;
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                richTextBox1.SelectionFont = new Font(selectedFont, currentSize, currentStyle);
            }
        }

        private void cmbSAI_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                float selectedSize;
                if (float.TryParse(cmbSAI.Text, out selectedSize))
                {
                    string currentFont = richTextBox1.SelectionFont.FontFamily.Name;
                    FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                    richTextBox1.SelectionFont = new Font(currentFont, selectedSize, currentStyle);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập kích thước hợp lệ.");
                    cmbSAI.Text = richTextBox1.SelectionFont.Size.ToString();
                }
            }

        }

        private void TMFile_Click(object sender, EventArgs e)
        {
            btnNEW_Click(sender, e);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog.FileName;
                richTextBox1.LoadFile(currentFile);

            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            btnSAVE_Click(sender, e);
        }

        private void lblTSC_Click(object sender, EventArgs e)
        {
           if( lblTSC.Text == "Tổng số ký tự: 0")
            {
                lblTSC.Text = "Tổng số ký tự: " + richTextBox1.Text.Length.ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {   
            int charCount = richTextBox1.Text.Length;
            lblTSC.Text = "Tổng số ký tự: " + charCount.ToString();
        }
    }
    
}

