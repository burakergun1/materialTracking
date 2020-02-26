namespace BarcodOlusturma
{
    partial class FrmProductRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_camOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime_productdate = new System.Windows.Forms.DateTimePicker();
            this.btn_productRegister = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barkod :";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(244, 327);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(222, 27);
            this.txt_barcode.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(101, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 264);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(101, 18);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(188, 28);
            this.cboCamera.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kamera :";
            // 
            // btn_camOpen
            // 
            this.btn_camOpen.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camOpen.Location = new System.Drawing.Point(295, 14);
            this.btn_camOpen.Name = "btn_camOpen";
            this.btn_camOpen.Size = new System.Drawing.Size(145, 35);
            this.btn_camOpen.TabIndex = 10;
            this.btn_camOpen.Text = "Kamera Aç";
            this.btn_camOpen.UseVisualStyleBackColor = true;
            this.btn_camOpen.Click += new System.EventHandler(this.btn_camOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_product
            // 
            this.txt_product.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.Location = new System.Drawing.Point(244, 355);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(222, 27);
            this.txt_product.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ürün Adi :";
            // 
            // dateTime_productdate
            // 
            this.dateTime_productdate.Location = new System.Drawing.Point(445, 135);
            this.dateTime_productdate.Name = "dateTime_productdate";
            this.dateTime_productdate.Size = new System.Drawing.Size(200, 20);
            this.dateTime_productdate.TabIndex = 13;
            this.dateTime_productdate.Visible = false;
            // 
            // btn_productRegister
            // 
            this.btn_productRegister.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productRegister.Location = new System.Drawing.Point(472, 332);
            this.btn_productRegister.Name = "btn_productRegister";
            this.btn_productRegister.Size = new System.Drawing.Size(162, 35);
            this.btn_productRegister.TabIndex = 14;
            this.btn_productRegister.Text = "Ürünü Kaydet";
            this.btn_productRegister.UseVisualStyleBackColor = true;
            this.btn_productRegister.Click += new System.EventHandler(this.btn_productRegister_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(573, 14);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(97, 35);
            this.btn_menu.TabIndex = 15;
            this.btn_menu.Text = "Menü";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Monaco", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(258, 395);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(128, 16);
            this.lbl_message.TabIndex = 16;
            this.lbl_message.Text = "Kullanıcı Adı :";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Visible = false;
            // 
            // FrmProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 440);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_productRegister);
            this.Controls.Add(this.dateTime_productdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.btn_camOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barcode);
            this.MaximizeBox = false;
            this.Name = "FrmProductRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReadBarcode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReadBarcode_FormClosing);
            this.Load += new System.EventHandler(this.FrmReadBarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_camOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime_productdate;
        private System.Windows.Forms.Button btn_productRegister;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label lbl_message;
    }
}