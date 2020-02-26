namespace BarcodOlusturma
{
    partial class FrmPasswordChange
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
            this.btn_changepassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oldpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_newpassword2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepassword.Location = new System.Drawing.Point(257, 327);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Size = new System.Drawing.Size(113, 57);
            this.btn_changepassword.TabIndex = 5;
            this.btn_changepassword.Text = "Şifremi Değiştir";
            this.btn_changepassword.UseVisualStyleBackColor = true;
            this.btn_changepassword.Click += new System.EventHandler(this.btn_changepassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Eski Şifre :";
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.BackColor = System.Drawing.SystemColors.Control;
            this.txt_oldpassword.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldpassword.ForeColor = System.Drawing.Color.Black;
            this.txt_oldpassword.Location = new System.Drawing.Point(236, 197);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.Size = new System.Drawing.Size(144, 26);
            this.txt_oldpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Control;
            this.txt_username.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(236, 166);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(144, 26);
            this.txt_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yeni Şifre :";
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.BackColor = System.Drawing.SystemColors.Control;
            this.txt_newpassword.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword.ForeColor = System.Drawing.Color.Black;
            this.txt_newpassword.Location = new System.Drawing.Point(236, 229);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.Size = new System.Drawing.Size(144, 26);
            this.txt_newpassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Yeni Şifre :";
            // 
            // txt_newpassword2
            // 
            this.txt_newpassword2.BackColor = System.Drawing.SystemColors.Control;
            this.txt_newpassword2.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword2.ForeColor = System.Drawing.Color.Black;
            this.txt_newpassword2.Location = new System.Drawing.Point(236, 261);
            this.txt_newpassword2.Name = "txt_newpassword2";
            this.txt_newpassword2.Size = new System.Drawing.Size(144, 26);
            this.txt_newpassword2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 135);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(201, 299);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(128, 16);
            this.lbl_message.TabIndex = 23;
            this.lbl_message.Text = "Kullanıcı Adı :";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Visible = false;
            // 
            // FrmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(493, 426);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_newpassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.btn_changepassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_oldpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Name = "FrmPasswordChange";
            this.Text = "FrmPasswordChange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_changepassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oldpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_newpassword2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_message;
    }
}