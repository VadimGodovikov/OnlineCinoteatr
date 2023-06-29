namespace OnlineCinoteatr.Forms.Функции
{
    partial class CheckUserPodpiska
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckUserPodpiska));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idpodpiskaText = new System.Windows.Forms.TextBox();
            this.hranimProc = new System.Windows.Forms.DataGridView();
            this.hranimProcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hranimProc)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "Хранимая процедура";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Просмотр пользователей с определённой подпиской";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Введите код подписки";
            // 
            // idpodpiskaText
            // 
            this.idpodpiskaText.Location = new System.Drawing.Point(166, 72);
            this.idpodpiskaText.Name = "idpodpiskaText";
            this.idpodpiskaText.Size = new System.Drawing.Size(148, 20);
            this.idpodpiskaText.TabIndex = 25;
            // 
            // hranimProc
            // 
            this.hranimProc.BackgroundColor = System.Drawing.Color.Khaki;
            this.hranimProc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hranimProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hranimProc.DefaultCellStyle = dataGridViewCellStyle2;
            this.hranimProc.GridColor = System.Drawing.Color.Salmon;
            this.hranimProc.Location = new System.Drawing.Point(28, 98);
            this.hranimProc.Name = "hranimProc";
            this.hranimProc.Size = new System.Drawing.Size(545, 340);
            this.hranimProc.TabIndex = 36;
            this.hranimProc.Visible = false;
            // 
            // hranimProcButton
            // 
            this.hranimProcButton.BackColor = System.Drawing.Color.Salmon;
            this.hranimProcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hranimProcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hranimProcButton.Location = new System.Drawing.Point(343, 68);
            this.hranimProcButton.Name = "hranimProcButton";
            this.hranimProcButton.Size = new System.Drawing.Size(108, 23);
            this.hranimProcButton.TabIndex = 37;
            this.hranimProcButton.Text = "Вывод";
            this.hranimProcButton.UseVisualStyleBackColor = false;
            this.hranimProcButton.Click += new System.EventHandler(this.hranimProcButton_Click);
            // 
            // CheckUserPodpiska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.hranimProcButton);
            this.Controls.Add(this.hranimProc);
            this.Controls.Add(this.idpodpiskaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckUserPodpiska";
            this.Text = "Просмотр пользователей с определённой подпиской";
            ((System.ComponentModel.ISupportInitialize)(this.hranimProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idpodpiskaText;
        private System.Windows.Forms.DataGridView hranimProc;
        private System.Windows.Forms.Button hranimProcButton;
    }
}