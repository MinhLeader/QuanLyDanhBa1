namespace QuanLyDanhBa1
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSign = new System.Windows.Forms.PictureBox();
            this.btnGoogle = new System.Windows.Forms.PictureBox();
            this.btnFaceBook = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new ZBobb.AlphaBlendTextBox();
            this.txtName = new ZBobb.AlphaBlendTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaceBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.btnSign);
            this.bunifuGradientPanel1.Controls.Add(this.btnGoogle);
            this.bunifuGradientPanel1.Controls.Add(this.btnFaceBook);
            this.bunifuGradientPanel1.Controls.Add(this.btnLog);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.txtPass);
            this.bunifuGradientPanel1.Controls.Add(this.txtName);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Window;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(567, 601);
            this.bunifuGradientPanel1.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(536, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 20;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Transparent;
            this.btnSign.Image = ((System.Drawing.Image)(resources.GetObject("btnSign.Image")));
            this.btnSign.Location = new System.Drawing.Point(381, 480);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(100, 90);
            this.btnSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSign.TabIndex = 19;
            this.btnSign.TabStop = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.Transparent;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.Location = new System.Drawing.Point(238, 480);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(100, 90);
            this.btnGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGoogle.TabIndex = 19;
            this.btnGoogle.TabStop = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnFaceBook
            // 
            this.btnFaceBook.BackColor = System.Drawing.Color.Transparent;
            this.btnFaceBook.Image = ((System.Drawing.Image)(resources.GetObject("btnFaceBook.Image")));
            this.btnFaceBook.Location = new System.Drawing.Point(104, 480);
            this.btnFaceBook.Name = "btnFaceBook";
            this.btnFaceBook.Size = new System.Drawing.Size(100, 90);
            this.btnFaceBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFaceBook.TabIndex = 19;
            this.btnFaceBook.TabStop = false;
            this.btnFaceBook.Click += new System.EventHandler(this.btnFaceBook_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(207, 380);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(170, 70);
            this.btnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLog.TabIndex = 18;
            this.btnLog.TabStop = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(104, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 2);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(104, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 2);
            this.panel1.TabIndex = 15;
            // 
            // txtPass
            // 
            this.txtPass.BackAlpha = 0;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(207, 311);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(274, 33);
            this.txtPass.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BackAlpha = 0;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(207, 237);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 33);
            this.txtName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "PASWORD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(137, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "PHONEBOOK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME:";
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 601);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaceBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ZBobb.AlphaBlendTextBox txtName;
        private System.Windows.Forms.Label label2;
        private ZBobb.AlphaBlendTextBox txtPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnLog;
        private System.Windows.Forms.PictureBox btnFaceBook;
        private System.Windows.Forms.PictureBox btnSign;
        private System.Windows.Forms.PictureBox btnGoogle;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
    }
}

