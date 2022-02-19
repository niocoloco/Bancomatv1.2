namespace Bancomat
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_pw = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.autentication_Box = new System.Windows.Forms.GroupBox();
            this.btn_visiblepw = new System.Windows.Forms.Button();
            this.lbl_pwerr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_version = new System.Windows.Forms.Label();
            this.time_date = new System.Windows.Forms.Timer(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autentication_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(10, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nome";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Location = new System.Drawing.Point(10, 104);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(98, 25);
            this.lbl_pw.TabIndex = 1;
            this.lbl_pw.Text = "Password";
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(114, 48);
            this.box_name.MaxLength = 16;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(151, 30);
            this.box_name.TabIndex = 2;
            // 
            // box_pw
            // 
            this.box_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_pw.Location = new System.Drawing.Point(114, 101);
            this.box_pw.MaxLength = 16;
            this.box_pw.Name = "box_pw";
            this.box_pw.Size = new System.Drawing.Size(151, 30);
            this.box_pw.TabIndex = 3;
            this.box_pw.UseSystemPasswordChar = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(15, 156);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Registrati";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(114, 156);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Annulla";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // autentication_Box
            // 
            this.autentication_Box.Controls.Add(this.btn_visiblepw);
            this.autentication_Box.Controls.Add(this.lbl_pwerr);
            this.autentication_Box.Controls.Add(this.box_name);
            this.autentication_Box.Controls.Add(this.btn_register);
            this.autentication_Box.Controls.Add(this.btn_cancel);
            this.autentication_Box.Controls.Add(this.lbl_name);
            this.autentication_Box.Controls.Add(this.box_pw);
            this.autentication_Box.Controls.Add(this.lbl_pw);
            this.autentication_Box.Location = new System.Drawing.Point(3, 41);
            this.autentication_Box.Name = "autentication_Box";
            this.autentication_Box.Size = new System.Drawing.Size(310, 279);
            this.autentication_Box.TabIndex = 6;
            this.autentication_Box.TabStop = false;
            this.autentication_Box.Text = "Autenticazione";
            // 
            // btn_visiblepw
            // 
            this.btn_visiblepw.Location = new System.Drawing.Point(271, 107);
            this.btn_visiblepw.Name = "btn_visiblepw";
            this.btn_visiblepw.Size = new System.Drawing.Size(20, 20);
            this.btn_visiblepw.TabIndex = 7;
            this.btn_visiblepw.Text = "👁";
            this.btn_visiblepw.UseVisualStyleBackColor = true;
            this.btn_visiblepw.Click += new System.EventHandler(this.btn_visiblepw_Click);
            // 
            // lbl_pwerr
            // 
            this.lbl_pwerr.AutoSize = true;
            this.lbl_pwerr.ForeColor = System.Drawing.Color.Red;
            this.lbl_pwerr.Location = new System.Drawing.Point(114, 176);
            this.lbl_pwerr.Name = "lbl_pwerr";
            this.lbl_pwerr.Size = new System.Drawing.Size(0, 13);
            this.lbl_pwerr.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 279);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opzioniToolStripMenuItem,
            this.creatoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
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
            // creatoreToolStripMenuItem
            // 
            this.creatoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoreToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.creatoreToolStripMenuItem.Name = "creatoreToolStripMenuItem";
            this.creatoreToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.creatoreToolStripMenuItem.Text = "?";
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
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(0, 434);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(35, 13);
            this.lbl_version.TabIndex = 9;
            this.lbl_version.Text = "V. 1.2";
            this.lbl_version.Click += new System.EventHandler(this.lbl_version_Click);
            // 
            // time_date
            // 
            this.time_date.Tick += new System.EventHandler(this.time_date_Tick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(86, 69);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 25);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "data";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(108, 34);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(40, 25);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "ora";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(588, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.autentication_Box);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrati";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.autentication_Box.ResumeLayout(false);
            this.autentication_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox box_pw;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox autentication_Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatoreToolStripMenuItem;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_pwerr;
        private System.Windows.Forms.Button btn_visiblepw;
        private System.Windows.Forms.Timer time_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem autoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
    }
}

