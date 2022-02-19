namespace Bancomat
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addmoney = new System.Windows.Forms.Button();
            this.txt_moneytoadd = new System.Windows.Forms.TextBox();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btm_prelievo = new System.Windows.Forms.Button();
            this.txt_prelievo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_pwvisible = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(41, 146);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(26, 39);
            this.lbl_balance.TabIndex = 1;
            this.lbl_balance.Text = " ";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_euro.Location = new System.Drawing.Point(12, 146);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(36, 39);
            this.lbl_euro.TabIndex = 2;
            this.lbl_euro.Text = "€";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_balance);
            this.groupBox1.Controls.Add(this.lbl_euro);
            this.groupBox1.Location = new System.Drawing.Point(17, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Il tuo conto";
            // 
            // btn_addmoney
            // 
            this.btn_addmoney.Location = new System.Drawing.Point(12, 379);
            this.btn_addmoney.Name = "btn_addmoney";
            this.btn_addmoney.Size = new System.Drawing.Size(121, 28);
            this.btn_addmoney.TabIndex = 4;
            this.btn_addmoney.Text = "Aggiungi soldi";
            this.btn_addmoney.UseVisualStyleBackColor = true;
            this.btn_addmoney.Click += new System.EventHandler(this.btn_addmoney_Click);
            // 
            // txt_moneytoadd
            // 
            this.txt_moneytoadd.Location = new System.Drawing.Point(139, 384);
            this.txt_moneytoadd.MaxLength = 9;
            this.txt_moneytoadd.Name = "txt_moneytoadd";
            this.txt_moneytoadd.Size = new System.Drawing.Size(121, 20);
            this.txt_moneytoadd.TabIndex = 5;
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Location = new System.Drawing.Point(12, 342);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(98, 25);
            this.lbl_pw.TabIndex = 6;
            this.lbl_pw.Text = "Password";
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(139, 347);
            this.txt_pw.MaxLength = 16;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(121, 20);
            this.txt_pw.TabIndex = 7;
            this.txt_pw.UseSystemPasswordChar = true;
            // 
            // btm_prelievo
            // 
            this.btm_prelievo.Location = new System.Drawing.Point(12, 412);
            this.btm_prelievo.Name = "btm_prelievo";
            this.btm_prelievo.Size = new System.Drawing.Size(121, 28);
            this.btm_prelievo.TabIndex = 8;
            this.btm_prelievo.Text = "Prelieva";
            this.btm_prelievo.UseVisualStyleBackColor = true;
            this.btm_prelievo.Click += new System.EventHandler(this.btm_prelievo_Click);
            // 
            // txt_prelievo
            // 
            this.txt_prelievo.Location = new System.Drawing.Point(139, 417);
            this.txt_prelievo.MaxLength = 9;
            this.txt_prelievo.Name = "txt_prelievo";
            this.txt_prelievo.Size = new System.Drawing.Size(121, 20);
            this.txt_prelievo.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opzioniToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem});
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoreToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // autoreToolStripMenuItem
            // 
            this.autoreToolStripMenuItem.Name = "autoreToolStripMenuItem";
            this.autoreToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.autoreToolStripMenuItem.Text = "Autore";
            this.autoreToolStripMenuItem.Click += new System.EventHandler(this.autoreToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 270);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_pwvisible
            // 
            this.btn_pwvisible.Location = new System.Drawing.Point(266, 347);
            this.btn_pwvisible.Name = "btn_pwvisible";
            this.btn_pwvisible.Size = new System.Drawing.Size(20, 20);
            this.btn_pwvisible.TabIndex = 12;
            this.btn_pwvisible.Text = "👁";
            this.btn_pwvisible.UseVisualStyleBackColor = true;
            this.btn_pwvisible.Click += new System.EventHandler(this.btn_pwvisible_Click);
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(109, 39);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(40, 25);
            this.lbl_time.TabIndex = 13;
            this.lbl_time.Text = "ora";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(86, 69);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 25);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_date);
            this.groupBox2.Controls.Add(this.lbl_time);
            this.groupBox2.Location = new System.Drawing.Point(589, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_pwvisible);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_prelievo);
            this.Controls.Add(this.btm_prelievo);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.txt_moneytoadd);
            this.Controls.Add(this.btn_addmoney);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conto";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addmoney;
        private System.Windows.Forms.TextBox txt_moneytoadd;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btm_prelievo;
        private System.Windows.Forms.TextBox txt_prelievo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_pwvisible;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}