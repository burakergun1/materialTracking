namespace BarcodOlusturma
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btn_productRegister = new System.Windows.Forms.Button();
            this.btn_productList = new System.Windows.Forms.Button();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_productSubtract = new System.Windows.Forms.Button();
            this.btn_AddBarcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_productRegister
            // 
            this.btn_productRegister.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_productRegister.Location = new System.Drawing.Point(132, 163);
            this.btn_productRegister.Name = "btn_productRegister";
            this.btn_productRegister.Size = new System.Drawing.Size(308, 56);
            this.btn_productRegister.TabIndex = 15;
            this.btn_productRegister.Text = "Ürün Kaydetme Menüsü";
            this.btn_productRegister.UseVisualStyleBackColor = true;
            this.btn_productRegister.Click += new System.EventHandler(this.btn_productRegister_Click);
            // 
            // btn_productList
            // 
            this.btn_productList.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productList.Location = new System.Drawing.Point(132, 216);
            this.btn_productList.Name = "btn_productList";
            this.btn_productList.Size = new System.Drawing.Size(308, 56);
            this.btn_productList.TabIndex = 16;
            this.btn_productList.Text = "Ürün Listele Menüsü";
            this.btn_productList.UseVisualStyleBackColor = true;
            this.btn_productList.Click += new System.EventHandler(this.btn_productList_Click);
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.Location = new System.Drawing.Point(132, 268);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.Size = new System.Drawing.Size(308, 56);
            this.btn_productAdd.TabIndex = 17;
            this.btn_productAdd.Text = "Ürün Adet Ekleme";
            this.btn_productAdd.UseVisualStyleBackColor = true;
            this.btn_productAdd.Click += new System.EventHandler(this.btn_productAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_productSubtract
            // 
            this.btn_productSubtract.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productSubtract.Location = new System.Drawing.Point(132, 321);
            this.btn_productSubtract.Name = "btn_productSubtract";
            this.btn_productSubtract.Size = new System.Drawing.Size(308, 56);
            this.btn_productSubtract.TabIndex = 19;
            this.btn_productSubtract.Text = "Ürün Miktar Çıkarma";
            this.btn_productSubtract.UseVisualStyleBackColor = true;
            this.btn_productSubtract.Click += new System.EventHandler(this.btn_productSubtract_Click);
            // 
            // btn_AddBarcode
            // 
            this.btn_AddBarcode.Font = new System.Drawing.Font("Monaco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBarcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AddBarcode.Location = new System.Drawing.Point(132, 374);
            this.btn_AddBarcode.Name = "btn_AddBarcode";
            this.btn_AddBarcode.Size = new System.Drawing.Size(308, 56);
            this.btn_AddBarcode.TabIndex = 20;
            this.btn_AddBarcode.Text = "Barkod Ekleme ";
            this.btn_AddBarcode.UseVisualStyleBackColor = true;
            this.btn_AddBarcode.Click += new System.EventHandler(this.btn_AddBarcode_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 510);
            this.Controls.Add(this.btn_AddBarcode);
            this.Controls.Add(this.btn_productSubtract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_productAdd);
            this.Controls.Add(this.btn_productList);
            this.Controls.Add(this.btn_productRegister);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÜ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_productRegister;
        private System.Windows.Forms.Button btn_productList;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_productSubtract;
        private System.Windows.Forms.Button btn_AddBarcode;
    }
}