namespace BarcodOlusturma
{
    partial class FrmProductAddAmount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.dateTime_productdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_camOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_productValue = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_productHistory = new System.Windows.Forms.Button();
            this.cmb_productName = new System.Windows.Forms.ComboBox();
            this.cmb_measure = new System.Windows.Forms.ComboBox();
            this.txt_newValue = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.Location = new System.Drawing.Point(281, 71);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.Size = new System.Drawing.Size(230, 35);
            this.btn_productAdd.TabIndex = 20;
            this.btn_productAdd.Text = "Ürünü Kaydet";
            this.btn_productAdd.UseVisualStyleBackColor = true;
            this.btn_productAdd.Click += new System.EventHandler(this.btn_productAdd_Click);
            // 
            // dateTime_productdate
            // 
            this.dateTime_productdate.Location = new System.Drawing.Point(452, 93);
            this.dateTime_productdate.Name = "dateTime_productdate";
            this.dateTime_productdate.Size = new System.Drawing.Size(200, 20);
            this.dateTime_productdate.TabIndex = 19;
            this.dateTime_productdate.Visible = false;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(-3, 82);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(109, 20);
            this.lbl_productName.TabIndex = 18;
            this.lbl_productName.Text = "Ürün Adi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Barkod :";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(106, 50);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.ReadOnly = true;
            this.txt_barcode.Size = new System.Drawing.Size(160, 27);
            this.txt_barcode.TabIndex = 15;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(685, 1);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(68, 35);
            this.btn_menu.TabIndex = 26;
            this.btn_menu.Text = "Menü";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_camOpen
            // 
            this.btn_camOpen.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camOpen.Location = new System.Drawing.Point(270, 8);
            this.btn_camOpen.Name = "btn_camOpen";
            this.btn_camOpen.Size = new System.Drawing.Size(119, 35);
            this.btn_camOpen.TabIndex = 25;
            this.btn_camOpen.Text = "Kamera Aç";
            this.btn_camOpen.UseVisualStyleBackColor = true;
            this.btn_camOpen.Click += new System.EventHandler(this.btn_camOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kamera :";
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(106, 8);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(158, 28);
            this.cboCamera.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 264);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lbl_productValue
            // 
            this.lbl_productValue.AutoSize = true;
            this.lbl_productValue.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productValue.Location = new System.Drawing.Point(17, 109);
            this.lbl_productValue.Name = "lbl_productValue";
            this.lbl_productValue.Size = new System.Drawing.Size(89, 20);
            this.lbl_productValue.TabIndex = 27;
            this.lbl_productValue.Text = "Miktar :";
            // 
            // txt_value
            // 
            this.txt_value.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_value.Location = new System.Drawing.Point(106, 106);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(61, 27);
            this.txt_value.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 226);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_productHistory
            // 
            this.btn_productHistory.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productHistory.Location = new System.Drawing.Point(474, 1);
            this.btn_productHistory.Name = "btn_productHistory";
            this.btn_productHistory.Size = new System.Drawing.Size(205, 35);
            this.btn_productHistory.TabIndex = 30;
            this.btn_productHistory.Text = "Ürün Ekleme Geçmişi";
            this.btn_productHistory.UseVisualStyleBackColor = true;
            this.btn_productHistory.Click += new System.EventHandler(this.btn_productHistory_Click);
            // 
            // cmb_productName
            // 
            this.cmb_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productName.Enabled = false;
            this.cmb_productName.Font = new System.Drawing.Font("Monaco", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_productName.FormattingEnabled = true;
            this.cmb_productName.Location = new System.Drawing.Point(106, 78);
            this.cmb_productName.Name = "cmb_productName";
            this.cmb_productName.Size = new System.Drawing.Size(160, 28);
            this.cmb_productName.TabIndex = 55;
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
            this.cmb_measure.Location = new System.Drawing.Point(171, 108);
            this.cmb_measure.Name = "cmb_measure";
            this.cmb_measure.Size = new System.Drawing.Size(93, 24);
            this.cmb_measure.TabIndex = 56;
            this.cmb_measure.SelectedIndexChanged += new System.EventHandler(this.cmb_measure_SelectedIndexChanged);
            // 
            // txt_newValue
            // 
            this.txt_newValue.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_newValue.Location = new System.Drawing.Point(272, 108);
            this.txt_newValue.Name = "txt_newValue";
            this.txt_newValue.Size = new System.Drawing.Size(61, 22);
            this.txt_newValue.TabIndex = 57;
            this.txt_newValue.Visible = false;
            // 
            // FrmProductAddAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 415);
            this.Controls.Add(this.txt_newValue);
            this.Controls.Add(this.cmb_measure);
            this.Controls.Add(this.cmb_productName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_productHistory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_productValue);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_camOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btn_productAdd);
            this.Controls.Add(this.dateTime_productdate);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_barcode);
            this.Name = "FrmProductAddAmount";
            this.Text = "FrmProductAddAmount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProductAddAmount_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductAddAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.DateTimePicker dateTime_productdate;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_camOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_productValue;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_productHistory;
        private System.Windows.Forms.ComboBox cmb_productName;
        private System.Windows.Forms.ComboBox cmb_measure;
        private System.Windows.Forms.TextBox txt_newValue;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}