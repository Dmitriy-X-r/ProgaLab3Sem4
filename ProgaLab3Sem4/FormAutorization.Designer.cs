namespace ProgaLab2Sem4
{
    partial class FormAutorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(169, 116);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(266, 22);
            this.txtBoxUserName.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(169, 152);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(266, 22);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(42, 210);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(100, 28);
            this.btnEntry.TabIndex = 4;
            this.btnEntry.Text = "Вход";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 210);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(-5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Версия 1.0.0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(-8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "АИС Отдел кадров";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-5, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите имя пользователя и пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
         
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAutorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

