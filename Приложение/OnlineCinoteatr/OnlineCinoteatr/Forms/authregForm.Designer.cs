namespace OnlineCinoteatr
{
    partial class authregForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authregForm));
            this.authoBut = new System.Windows.Forms.Button();
            this.regBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authoBut
            // 
            this.authoBut.BackColor = System.Drawing.Color.Red;
            this.authoBut.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.authoBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authoBut.ForeColor = System.Drawing.SystemColors.Control;
            this.authoBut.Location = new System.Drawing.Point(106, 122);
            this.authoBut.Name = "authoBut";
            this.authoBut.Size = new System.Drawing.Size(211, 47);
            this.authoBut.TabIndex = 0;
            this.authoBut.Text = "Авторизоваться";
            this.authoBut.UseVisualStyleBackColor = false;
            this.authoBut.UseWaitCursor = true;
            this.authoBut.Click += new System.EventHandler(this.authoBut_Click);
            // 
            // regBut
            // 
            this.regBut.BackColor = System.Drawing.Color.Red;
            this.regBut.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.regBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBut.ForeColor = System.Drawing.SystemColors.Control;
            this.regBut.Location = new System.Drawing.Point(106, 203);
            this.regBut.Name = "regBut";
            this.regBut.Size = new System.Drawing.Size(211, 49);
            this.regBut.TabIndex = 1;
            this.regBut.Text = "Зарегистрироваться";
            this.regBut.UseVisualStyleBackColor = false;
            this.regBut.UseWaitCursor = true;
            this.regBut.Click += new System.EventHandler(this.regBut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(318, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authregForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regBut);
            this.Controls.Add(this.authoBut);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authregForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветствуем";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.authregForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authoBut;
        private System.Windows.Forms.Button regBut;
        private System.Windows.Forms.Button button1;
    }
}

