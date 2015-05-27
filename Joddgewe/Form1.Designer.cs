namespace Joddgewe
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageJGW = new System.Windows.Forms.TabPage();
            this.textBoxJGW = new System.Windows.Forms.TextBox();
            this.tabPageMMM = new System.Windows.Forms.TabPage();
            this.textBoxMMM = new System.Windows.Forms.TextBox();
            this.tabPageSOSI = new System.Windows.Forms.TabPage();
            this.textBoxSOSI = new System.Windows.Forms.TextBox();
            this.lblVisEgenskaper = new System.Windows.Forms.Label();
            this.lblUtformat = new System.Windows.Forms.Label();
            this.listBoxFiler = new System.Windows.Forms.ListBox();
            this.btnFullfør = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pictboxOrtofoto = new System.Windows.Forms.PictureBox();
            this.radioButtonJGW = new System.Windows.Forms.RadioButton();
            this.radioButtonMMM = new System.Windows.Forms.RadioButton();
            this.radioButtonSOSI = new System.Windows.Forms.RadioButton();
            this.groupBoxFilformat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxFilliste = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFilliste = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageJGW.SuspendLayout();
            this.tabPageMMM.SuspendLayout();
            this.tabPageSOSI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxOrtofoto)).BeginInit();
            this.groupBoxFilformat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxFilliste.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.fileToolStripMenuItem.Text = "Fil";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Åpne";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.closeToolStripMenuItem.Text = "Avslutt";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Hjelp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "Om JoddGewe...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageJGW);
            this.tabControl.Controls.Add(this.tabPageMMM);
            this.tabControl.Controls.Add(this.tabPageSOSI);
            this.tabControl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(6, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(228, 192);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageJGW
            // 
            this.tabPageJGW.Controls.Add(this.textBoxJGW);
            this.tabPageJGW.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageJGW.Location = new System.Drawing.Point(4, 26);
            this.tabPageJGW.Name = "tabPageJGW";
            this.tabPageJGW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJGW.Size = new System.Drawing.Size(220, 162);
            this.tabPageJGW.TabIndex = 0;
            this.tabPageJGW.Text = "JGW/TFW";
            this.tabPageJGW.UseVisualStyleBackColor = true;
            // 
            // textBoxJGW
            // 
            this.textBoxJGW.Location = new System.Drawing.Point(0, 0);
            this.textBoxJGW.Multiline = true;
            this.textBoxJGW.Name = "textBoxJGW";
            this.textBoxJGW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJGW.Size = new System.Drawing.Size(220, 162);
            this.textBoxJGW.TabIndex = 0;
            // 
            // tabPageMMM
            // 
            this.tabPageMMM.Controls.Add(this.textBoxMMM);
            this.tabPageMMM.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMMM.Location = new System.Drawing.Point(4, 26);
            this.tabPageMMM.Name = "tabPageMMM";
            this.tabPageMMM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMMM.Size = new System.Drawing.Size(220, 162);
            this.tabPageMMM.TabIndex = 1;
            this.tabPageMMM.Text = "MMM";
            this.tabPageMMM.UseVisualStyleBackColor = true;
            // 
            // textBoxMMM
            // 
            this.textBoxMMM.Location = new System.Drawing.Point(0, 0);
            this.textBoxMMM.Multiline = true;
            this.textBoxMMM.Name = "textBoxMMM";
            this.textBoxMMM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMMM.Size = new System.Drawing.Size(220, 162);
            this.textBoxMMM.TabIndex = 1;
            // 
            // tabPageSOSI
            // 
            this.tabPageSOSI.Controls.Add(this.textBoxSOSI);
            this.tabPageSOSI.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSOSI.Location = new System.Drawing.Point(4, 26);
            this.tabPageSOSI.Name = "tabPageSOSI";
            this.tabPageSOSI.Size = new System.Drawing.Size(220, 162);
            this.tabPageSOSI.TabIndex = 2;
            this.tabPageSOSI.Text = "SOSI";
            this.tabPageSOSI.UseVisualStyleBackColor = true;
            // 
            // textBoxSOSI
            // 
            this.textBoxSOSI.Location = new System.Drawing.Point(0, 0);
            this.textBoxSOSI.Multiline = true;
            this.textBoxSOSI.Name = "textBoxSOSI";
            this.textBoxSOSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSOSI.Size = new System.Drawing.Size(220, 162);
            this.textBoxSOSI.TabIndex = 1;
            // 
            // lblVisEgenskaper
            // 
            this.lblVisEgenskaper.AutoSize = true;
            this.lblVisEgenskaper.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisEgenskaper.Location = new System.Drawing.Point(8, 24);
            this.lblVisEgenskaper.Name = "lblVisEgenskaper";
            this.lblVisEgenskaper.Size = new System.Drawing.Size(358, 18);
            this.lblVisEgenskaper.TabIndex = 4;
            this.lblVisEgenskaper.Text = "Klikk på et element i fillisten over for å forhåndsvise en fil...";
            // 
            // lblUtformat
            // 
            this.lblUtformat.AutoSize = true;
            this.lblUtformat.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtformat.Location = new System.Drawing.Point(8, 24);
            this.lblUtformat.Name = "lblUtformat";
            this.lblUtformat.Size = new System.Drawing.Size(204, 18);
            this.lblUtformat.TabIndex = 5;
            this.lblUtformat.Text = "Velg utformat på styringsfilene...";
            // 
            // listBoxFiler
            // 
            this.listBoxFiler.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxFiler.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxFiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxFiler.FormattingEnabled = true;
            this.listBoxFiler.HorizontalScrollbar = true;
            this.listBoxFiler.Location = new System.Drawing.Point(7, 46);
            this.listBoxFiler.Name = "listBoxFiler";
            this.listBoxFiler.Size = new System.Drawing.Size(448, 108);
            this.listBoxFiler.TabIndex = 9;
            this.listBoxFiler.SelectedIndexChanged += new System.EventHandler(this.listBoxFiler_SelectedIndexChanged);
            // 
            // btnFullfør
            // 
            this.btnFullfør.Enabled = false;
            this.btnFullfør.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullfør.Location = new System.Drawing.Point(334, 69);
            this.btnFullfør.Name = "btnFullfør";
            this.btnFullfør.Size = new System.Drawing.Size(139, 32);
            this.btnFullfør.TabIndex = 10;
            this.btnFullfør.Text = "Lag styringsfiler!";
            this.btnFullfør.UseVisualStyleBackColor = true;
            this.btnFullfør.Click += new System.EventHandler(this.btnFullfør_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 30);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(458, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(458, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(26, 24);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pictboxOrtofoto
            // 
            this.pictboxOrtofoto.BackColor = System.Drawing.SystemColors.Window;
            this.pictboxOrtofoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictboxOrtofoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictboxOrtofoto.ErrorImage")));
            this.pictboxOrtofoto.Image = ((System.Drawing.Image)(resources.GetObject("pictboxOrtofoto.Image")));
            this.pictboxOrtofoto.InitialImage = null;
            this.pictboxOrtofoto.Location = new System.Drawing.Point(253, 83);
            this.pictboxOrtofoto.Name = "pictboxOrtofoto";
            this.pictboxOrtofoto.Size = new System.Drawing.Size(220, 162);
            this.pictboxOrtofoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxOrtofoto.TabIndex = 14;
            this.pictboxOrtofoto.TabStop = false;
            // 
            // radioButtonJGW
            // 
            this.radioButtonJGW.AutoSize = true;
            this.radioButtonJGW.Enabled = false;
            this.radioButtonJGW.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJGW.Location = new System.Drawing.Point(11, 48);
            this.radioButtonJGW.Name = "radioButtonJGW";
            this.radioButtonJGW.Size = new System.Drawing.Size(85, 21);
            this.radioButtonJGW.TabIndex = 15;
            this.radioButtonJGW.TabStop = true;
            this.radioButtonJGW.Text = "JGW/TFW";
            this.radioButtonJGW.UseVisualStyleBackColor = true;
            this.radioButtonJGW.CheckedChanged += new System.EventHandler(this.radioButtonJGW_CheckedChanged);
            // 
            // radioButtonMMM
            // 
            this.radioButtonMMM.AutoSize = true;
            this.radioButtonMMM.Enabled = false;
            this.radioButtonMMM.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMMM.Location = new System.Drawing.Point(99, 48);
            this.radioButtonMMM.Name = "radioButtonMMM";
            this.radioButtonMMM.Size = new System.Drawing.Size(62, 21);
            this.radioButtonMMM.TabIndex = 16;
            this.radioButtonMMM.TabStop = true;
            this.radioButtonMMM.Text = "MMM";
            this.radioButtonMMM.UseVisualStyleBackColor = true;
            this.radioButtonMMM.CheckedChanged += new System.EventHandler(this.radioButtonMMM_CheckedChanged);
            // 
            // radioButtonSOSI
            // 
            this.radioButtonSOSI.AutoSize = true;
            this.radioButtonSOSI.Enabled = false;
            this.radioButtonSOSI.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSOSI.Location = new System.Drawing.Point(164, 48);
            this.radioButtonSOSI.Name = "radioButtonSOSI";
            this.radioButtonSOSI.Size = new System.Drawing.Size(55, 21);
            this.radioButtonSOSI.TabIndex = 17;
            this.radioButtonSOSI.TabStop = true;
            this.radioButtonSOSI.Text = "SOSI";
            this.radioButtonSOSI.UseVisualStyleBackColor = true;
            this.radioButtonSOSI.CheckedChanged += new System.EventHandler(this.radioButtonSOSI_CheckedChanged);
            // 
            // groupBoxFilformat
            // 
            this.groupBoxFilformat.Controls.Add(this.checkBoxFilliste);
            this.groupBoxFilformat.Controls.Add(this.radioButtonSOSI);
            this.groupBoxFilformat.Controls.Add(this.radioButtonMMM);
            this.groupBoxFilformat.Controls.Add(this.radioButtonJGW);
            this.groupBoxFilformat.Controls.Add(this.btnFullfør);
            this.groupBoxFilformat.Controls.Add(this.lblUtformat);
            this.groupBoxFilformat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilformat.Location = new System.Drawing.Point(20, 493);
            this.groupBoxFilformat.Name = "groupBoxFilformat";
            this.groupBoxFilformat.Size = new System.Drawing.Size(490, 107);
            this.groupBoxFilformat.TabIndex = 21;
            this.groupBoxFilformat.TabStop = false;
            this.groupBoxFilformat.Text = "Filformat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictboxOrtofoto);
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Controls.Add(this.lblVisEgenskaper);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 255);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forhåndsvisning";
            // 
            // groupBoxFilliste
            // 
            this.groupBoxFilliste.Controls.Add(this.label1);
            this.groupBoxFilliste.Controls.Add(this.btnRemove);
            this.groupBoxFilliste.Controls.Add(this.btnAdd);
            this.groupBoxFilliste.Controls.Add(this.listBoxFiler);
            this.groupBoxFilliste.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilliste.Location = new System.Drawing.Point(20, 58);
            this.groupBoxFilliste.Name = "groupBoxFilliste";
            this.groupBoxFilliste.Size = new System.Drawing.Size(490, 166);
            this.groupBoxFilliste.TabIndex = 23;
            this.groupBoxFilliste.TabStop = false;
            this.groupBoxFilliste.Text = "Filliste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Åpne et eller flere ortofoto...";
            // 
            // checkBoxFilliste
            // 
            this.checkBoxFilliste.AutoSize = true;
            this.checkBoxFilliste.Checked = true;
            this.checkBoxFilliste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFilliste.Enabled = false;
            this.checkBoxFilliste.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.checkBoxFilliste.Location = new System.Drawing.Point(11, 80);
            this.checkBoxFilliste.Name = "checkBoxFilliste";
            this.checkBoxFilliste.Size = new System.Drawing.Size(165, 21);
            this.checkBoxFilliste.TabIndex = 18;
            this.checkBoxFilliste.Text = "Lag filliste for NovaPoint";
            this.checkBoxFilliste.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 636);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxFilliste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFilformat);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 670);
            this.MinimumSize = new System.Drawing.Size(540, 670);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoddGewe 0.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageJGW.ResumeLayout(false);
            this.tabPageJGW.PerformLayout();
            this.tabPageMMM.ResumeLayout(false);
            this.tabPageMMM.PerformLayout();
            this.tabPageSOSI.ResumeLayout(false);
            this.tabPageSOSI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxOrtofoto)).EndInit();
            this.groupBoxFilformat.ResumeLayout(false);
            this.groupBoxFilformat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFilliste.ResumeLayout(false);
            this.groupBoxFilliste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageJGW;
        private System.Windows.Forms.TabPage tabPageMMM;
        private System.Windows.Forms.TabPage tabPageSOSI;
        private System.Windows.Forms.Label lblVisEgenskaper;
        private System.Windows.Forms.Label lblUtformat;
        private System.Windows.Forms.ListBox listBoxFiler;
        private System.Windows.Forms.Button btnFullfør;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pictboxOrtofoto;
        private System.Windows.Forms.RadioButton radioButtonJGW;
        private System.Windows.Forms.RadioButton radioButtonMMM;
        private System.Windows.Forms.RadioButton radioButtonSOSI;
        private System.Windows.Forms.GroupBox groupBoxFilformat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxFilliste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJGW;
        private System.Windows.Forms.TextBox textBoxMMM;
        private System.Windows.Forms.TextBox textBoxSOSI;
        private System.Windows.Forms.CheckBox checkBoxFilliste;
    }
}

