namespace BaitTap5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.forntHT = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.TMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNEW = new System.Windows.Forms.ToolStripButton();
            this.btnSAVE = new System.Windows.Forms.ToolStripButton();
            this.cmbFornt = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSAI = new System.Windows.Forms.ToolStripComboBox();
            this.btnB = new System.Windows.Forms.ToolStripButton();
            this.btnI = new System.Windows.Forms.ToolStripButton();
            this.btnU = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTSC = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forntHT,
            this.FontDialog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNEW,
            this.btnSAVE,
            this.cmbFornt,
            this.cmbSAI,
            this.btnB,
            this.btnI,
            this.btnU});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // forntHT
            // 
            this.forntHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMFile,
            this.OpenFile,
            this.toolStripSeparator1,
            this.SaveFile,
            this.Exit});
            this.forntHT.Name = "forntHT";
            this.forntHT.Size = new System.Drawing.Size(72, 20);
            this.forntHT.Text = "Hệ Thống";
            // 
            // FontDialog
            // 
            this.FontDialog.Name = "FontDialog";
            this.FontDialog.Size = new System.Drawing.Size(75, 20);
            this.FontDialog.Text = "Định Dạng";
            this.FontDialog.Click += new System.EventHandler(this.FontDialog_Click);
            // 
            // TMFile
            // 
            this.TMFile.Image = ((System.Drawing.Image)(resources.GetObject("TMFile.Image")));
            this.TMFile.Name = "TMFile";
            this.TMFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TMFile.Size = new System.Drawing.Size(233, 22);
            this.TMFile.Text = "Tạo Văn Bản Mới";
            this.TMFile.Click += new System.EventHandler(this.TMFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(233, 22);
            this.OpenFile.Text = "Mở Tập Tin";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // SaveFile
            // 
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFile.Size = new System.Drawing.Size(233, 22);
            this.SaveFile.Text = "Lưu Nội Dung Văn bản";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(233, 22);
            this.Exit.Text = "Thoát";
            // 
            // btnNEW
            // 
            this.btnNEW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNEW.Image = ((System.Drawing.Image)(resources.GetObject("btnNEW.Image")));
            this.btnNEW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(23, 22);
            this.btnNEW.Text = "toolStripButton1";
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSAVE.Image = ((System.Drawing.Image)(resources.GetObject("btnSAVE.Image")));
            this.btnSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(23, 22);
            this.btnSAVE.Text = "toolStripButton2";
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // cmbFornt
            // 
            this.cmbFornt.Name = "cmbFornt";
            this.cmbFornt.Size = new System.Drawing.Size(121, 25);
            this.cmbFornt.SelectedIndexChanged += new System.EventHandler(this.cmbFornt_SelectedIndexChanged);
            // 
            // cmbSAI
            // 
            this.cmbSAI.Name = "cmbSAI";
            this.cmbSAI.Size = new System.Drawing.Size(121, 25);
            this.cmbSAI.Click += new System.EventHandler(this.cmbSAI_Click);
            // 
            // btnB
            // 
            this.btnB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(23, 22);
            this.btnB.Text = "toolStripButton3";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnI
            // 
            this.btnI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnI.Image = ((System.Drawing.Image)(resources.GetObject("btnI.Image")));
            this.btnI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(23, 22);
            this.btnI.Text = "toolStripButton4";
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnU
            // 
            this.btnU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnU.Image = ((System.Drawing.Image)(resources.GetObject("btnU.Image")));
            this.btnU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(23, 22);
            this.btnU.Text = "toolStripButton5";
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTSC});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTSC
            // 
            this.lblTSC.Name = "lblTSC";
            this.lblTSC.Size = new System.Drawing.Size(74, 17);
            this.lblTSC.Text = "Tổng Số  Từ:";
            this.lblTSC.Click += new System.EventHandler(this.lblTSC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn Thảo Văn Bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forntHT;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem FontDialog;
        private System.Windows.Forms.ToolStripMenuItem TMFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripButton btnNEW;
        private System.Windows.Forms.ToolStripButton btnSAVE;
        private System.Windows.Forms.ToolStripComboBox cmbFornt;
        private System.Windows.Forms.ToolStripComboBox cmbSAI;
        private System.Windows.Forms.ToolStripButton btnB;
        private System.Windows.Forms.ToolStripButton btnI;
        private System.Windows.Forms.ToolStripButton btnU;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTSC;
    }
}

