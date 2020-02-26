namespace BarcodOlusturma
{
    partial class FrmProductSubstractHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_productSubstractMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_camOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_productDetailSearch = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.cmb_productName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_productSubstractMenu
            // 
            this.btn_productSubstractMenu.Font = new System.Drawing.Font("Monaco", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productSubstractMenu.Location = new System.Drawing.Point(664, 5);
            this.btn_productSubstractMenu.Name = "btn_productSubstractMenu";
            this.btn_productSubstractMenu.Size = new System.Drawing.Size(112, 33);
            this.btn_productSubstractMenu.TabIndex = 77;
            this.btn_productSubstractMenu.Text = "Menü";
            this.btn_productSubstractMenu.UseVisualStyleBackColor = true;
            this.btn_productSubstractMenu.Click += new System.EventHandler(this.btn_productSubstractMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(1, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 328);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_camOpen
            // 
            this.btn_camOpen.Font = new System.Drawing.Font("Monaco", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camOpen.Location = new System.Drawing.Point(290, 91);
            this.btn_camOpen.Name = "btn_camOpen";
            this.btn_camOpen.Size = new System.Drawing.Size(119, 30);
            this.btn_camOpen.TabIndex = 75;
            this.btn_camOpen.Text = "Kamera Aç";
            this.btn_camOpen.UseVisualStyleBackColor = true;
            this.btn_camOpen.Visible = false;
            this.btn_camOpen.Click += new System.EventHandler(this.btn_camOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Kamera :";
            this.label4.Visible = false;
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(126, 96);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(158, 24);
            this.cboCamera.TabIndex = 73;
            this.cboCamera.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "Tarih 2 :";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tarih 1 :";
            this.label2.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(399, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 23);
            this.checkBox2.TabIndex = 70;
            this.checkBox2.Text = "Zaman Paneli";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(96, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 23);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Detaylı Ürün Arama";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 69);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 68;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 67;
            this.dateTimePicker1.Visible = false;
            // 
            // btn_productDetailSearch
            // 
            this.btn_productDetailSearch.Font = new System.Drawing.Font("Monaco", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productDetailSearch.Location = new System.Drawing.Point(616, 39);
            this.btn_productDetailSearch.Name = "btn_productDetailSearch";
            this.btn_productDetailSearch.Size = new System.Drawing.Size(160, 55);
            this.btn_productDetailSearch.TabIndex = 66;
            this.btn_productDetailSearch.Text = "Detaylı Ürün Arama";
            this.btn_productDetailSearch.UseVisualStyleBackColor = true;
            this.btn_productDetailSearch.Visible = false;
            this.btn_productDetailSearch.Click += new System.EventHandler(this.btn_productDetailSearch_Click);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(21, 69);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(99, 19);
            this.lbl_productName.TabIndex = 65;
            this.lbl_productName.Text = "Ürün Adi :";
            this.lbl_productName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Barkod :";
            this.label1.Visible = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barcode.Location = new System.Drawing.Point(126, 39);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(160, 22);
            this.txt_barcode.TabIndex = 63;
            this.txt_barcode.Visible = false;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // cmb_productName
            // 
            this.cmb_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_productName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_productName.FormattingEnabled = true;
            this.cmb_productName.Location = new System.Drawing.Point(126, 67);
            this.cmb_productName.Name = "cmb_productName";
            this.cmb_productName.Size = new System.Drawing.Size(160, 24);
            this.cmb_productName.TabIndex = 62;
            this.cmb_productName.Visible = false;
            this.cmb_productName.SelectedIndexChanged += new System.EventHandler(this.cmb_productName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(-18, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(794, 328);
            this.dataGridView1.TabIndex = 61;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmProductSubstractHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 468);
            this.Controls.Add(this.btn_productSubstractMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_camOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_productDetailSearch);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.cmb_productName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProductSubstractHistory";
            this.Text = "FrmProductSubstractHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductSubstractHistory_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductSubstractHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_productSubstractMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_camOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_productDetailSearch;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.ComboBox cmb_productName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}