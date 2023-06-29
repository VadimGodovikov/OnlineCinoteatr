namespace OnlineCinoteatr
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.loginText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.authBut = new System.Windows.Forms.Button();
            this.backBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.Location = new System.Drawing.Point(139, 110);
            this.loginText.Multiline = true;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(159, 26);
            this.loginText.TabIndex = 0;
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passText.Location = new System.Drawing.Point(139, 159);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '●';
            this.passText.Size = new System.Drawing.Size(159, 26);
            this.passText.TabIndex = 1;
            // 
            // authBut
            // 
            this.authBut.BackColor = System.Drawing.Color.Red;
            this.authBut.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.authBut.FlatAppearance.BorderSize = 0;
            this.authBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBut.ForeColor = System.Drawing.SystemColors.Control;
            this.authBut.Location = new System.Drawing.Point(139, 205);
            this.authBut.Name = "authBut";
            this.authBut.Size = new System.Drawing.Size(159, 36);
            this.authBut.TabIndex = 2;
            this.authBut.Text = "Войти";
            this.authBut.UseVisualStyleBackColor = false;
            this.authBut.Click += new System.EventHandler(this.authBut_Click);
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.Transparent;
            this.backBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBut.BackgroundImage")));
            this.backBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBut.FlatAppearance.BorderSize = 0;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.ForeColor = System.Drawing.Color.Transparent;
            this.backBut.Location = new System.Drawing.Point(12, 256);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(45, 39);
            this.backBut.TabIndex = 3;
            this.backBut.UseVisualStyleBackColor = false;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(45, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(45, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(120, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.authBut);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginText);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button authBut;
        private System.Windows.Forms.Button backBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}