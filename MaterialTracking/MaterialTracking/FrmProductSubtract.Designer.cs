namespace BarcodOlusturma
{
    partial class FrmProductSubtract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_newValue = new System.Windows.Forms.TextBox();
            this.cmb_measure = new System.Windows.Forms.ComboBox();
            this.cmb_productName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_productSubstractHistory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_productValue = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_camOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btn_productSubtract = new System.Windows.Forms.Button();
            this.dateTime_productdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_newValue
            // 
            this.txt_newValue.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_newValue.Location = new System.Drawing.Point(367, 146);
            this.txt_newValue.Name = "txt_newValue";
            this.txt_newValue.Size = new System.Drawing.Size(61, 22);
            this.txt_newValue.TabIndex = 74;
            // 
            // cmb_measure
            // 
            this.cmb_measure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_measure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_measure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_measure.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_measure.FormattingEnabled = true;
            this.cmb_measure.Items.AddRange(new object[] {
            "--Seçiniz--",
            "MiliGram",
            "Gram",
            "MikroLitre",
            "MiliLitre",
            "Litre"});
            this.cmb_measure.Location = new System.Drawing.Point(268, 149);
            this.cmb_measure.Name = "cmb_measure";
            this.cmb_measure.Size = new System.Drawing.Size(93, 24);
            this.cmb_measure.TabIndex = 73;
            this.cmb_measure.SelectedIndexChanged += new System.EventHandler(this.cmb_measure_SelectedIndexChanged);
            // 
            // cmb_productName
            // 
            this.cmb_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productName.Enabled = false;
            this.cmb_productName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_productName.FormattingEnabled = true;
            this.cmb_productName.Location = new System.Drawing.Point(201, 93);
            this.cmb_productName.Name = "cmb_productName";
            this.cmb_productName.Size = new System.Drawing.Size(160, 24);
            this.cmb_productName.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(23, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 264);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_productSubstractHistory
            // 
            this.btn_productSubstractHistory.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_productSubstractHistory.Location = new System.Drawing.Point(498, 20);
            this.btn_productSubstractHistory.Name = "btn_productSubstractHistory";
            this.btn_productSubstractHistory.Size = new System.Drawing.Size(205, 35);
            this.btn_productSubstractHistory.TabIndex = 71;
            this.btn_productSubstractHistory.Text = "Ürün Kullanma Geçmişi";
            this.btn_productSubstractHistory.UseVisualStyleBackColor = true;
            this.btn_productSubstractHistory.Click += new System.EventHandler(this.btn_productSubstractHistory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 226);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_value
            // 
            this.txt_value.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_value.Location = new System.Drawing.Point(201, 151);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(61, 22);
            this.txt_value.TabIndex = 69;
            // 
            // lbl_productValue
            // 
            this.lbl_productValue.AutoSize = true;
            this.lbl_productValue.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productValue.Location = new System.Drawing.Point(10, 152);
            this.lbl_productValue.Name = "lbl_productValue";
            this.lbl_productValue.Size = new System.Drawing.Size(185, 18);
            this.lbl_productValue.TabIndex = 68;
            this.lbl_productValue.Text = "Kullanılacak Miktar :";
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menu.Location = new System.Drawing.Point(709, 20);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(68, 35);
            this.btn_menu.TabIndex = 67;
            this.btn_menu.Text = "Menü";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_camOpen
            // 
            this.btn_camOpen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_camOpen.Location = new System.Drawing.Point(294, 27);
            this.btn_camOpen.Name = "btn_camOpen";
            this.btn_camOpen.Size = new System.Drawing.Size(119, 35);
            this.btn_camOpen.TabIndex = 66;
            this.btn_camOpen.Text = "Kamera Aç";
            this.btn_camOpen.UseVisualStyleBackColor = true;
            this.btn_camOpen.Click += new System.EventHandler(this.btn_camOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Kamera :";
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(130, 27);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(158, 24);
            this.cboCamera.TabIndex = 64;
            // 
            // btn_productSubtract
            // 
            this.btn_productSubtract.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_productSubtract.Location = new System.Drawing.Point(428, 105);
            this.btn_productSubtract.Name = "btn_productSubtract";
            this.btn_productSubtract.Size = new System.Drawing.Size(230, 35);
            this.btn_productSubtract.TabIndex = 62;
            this.btn_productSubtract.Text = "Ürünü Kullan";
            this.btn_productSubtract.UseVisualStyleBackColor = true;
            this.btn_productSubtract.Click += new System.EventHandler(this.btn_productSubtract_Click);
            // 
            // dateTime_productdate
            // 
            this.dateTime_productdate.Location = new System.Drawing.Point(476, 112);
            this.dateTime_productdate.Name = "dateTime_productdate";
            this.dateTime_productdate.Size = new System.Drawing.Size(200, 20);
            this.dateTime_productdate.TabIndex = 61;
            this.dateTime_productdate.Visible = false;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productName.Location = new System.Drawing.Point(101, 99);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(94, 18);
            this.lbl_productName.TabIndex = 60;
            this.lbl_productName.Text = "Ürün Adi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Barkod :";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barcode.Location = new System.Drawing.Point(201, 68);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.ReadOnly = true;
            this.txt_barcode.Size = new System.Drawing.Size(160, 22);
            this.txt_barcode.TabIndex = 58;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "Toplam Miktar :";
            // 
            // txt_productSum
            // 
            this.txt_productSum.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_productSum.Location = new System.Drawing.Point(201, 123);
            this.txt_productSum.Name = "txt_productSum";
            this.txt_productSum.Size = new System.Drawing.Size(61, 22);
            this.txt_productSum.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(268, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "Gram/MiliLitre";
            // 
            // FrmProductSubtract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_productSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_newValue);
            this.Controls.Add(this.cmb_measure);
            this.Controls.Add(this.cmb_productName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_productSubstractHistory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_productValue);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_camOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btn_productSubtract);
            this.Controls.Add(this.dateTime_productdate);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barcode);
            this.Name = "FrmProductSubtract";
            this.Text = "FrmProductSubtract";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductSubtract_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductSubtract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newValue;
        private System.Windows.Forms.ComboBox cmb_measure;
        private System.Windows.Forms.ComboBox cmb_productName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_productSubstractHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label lbl_productValue;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_camOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btn_productSubtract;
        private System.Windows.Forms.DateTimePicker dateTime_productdate;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productSum;
        private System.Windows.Forms.Label label4;
    }
}