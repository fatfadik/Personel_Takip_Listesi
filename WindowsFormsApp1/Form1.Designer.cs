namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Meslek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskd_maas = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pERSONEL_TAKİP_LİSTDataSet = new WindowsFormsApp1.PERSONEL_TAKİP_LİSTDataSet();
            this.tblPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PersonTableAdapter = new WindowsFormsApp1.PERSONEL_TAKİP_LİSTDataSetTableAdapters.tbl_PersonTableAdapter();
            this.personelDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelWageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelStatuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_TAKİP_LİSTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(88, 51);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(88, 91);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 22);
            this.txt_Ad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(88, 131);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 22);
            this.txt_Soyad.TabIndex = 6;
            this.txt_Soyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şehir";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(88, 177);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(121, 24);
            this.cmb_sehir.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maaş";
            // 
            // txt_Meslek
            // 
            this.txt_Meslek.Location = new System.Drawing.Point(88, 320);
            this.txt_Meslek.Name = "txt_Meslek";
            this.txt_Meslek.Size = new System.Drawing.Size(100, 22);
            this.txt_Meslek.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Meslek";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mskd_maas
            // 
            this.mskd_maas.Location = new System.Drawing.Point(88, 266);
            this.mskd_maas.Mask = "00000";
            this.mskd_maas.Name = "mskd_maas";
            this.mskd_maas.Size = new System.Drawing.Size(100, 22);
            this.mskd_maas.TabIndex = 15;
            this.mskd_maas.ValidatingType = typeof(int);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 225);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 225);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(263, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 291);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(6, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(6, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(6, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelDDataGridViewTextBoxColumn,
            this.personelNameDataGridViewTextBoxColumn,
            this.personelCityDataGridViewTextBoxColumn,
            this.personelWageDataGridViewTextBoxColumn,
            this.personelStatuDataGridViewTextBoxColumn,
            this.personelJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(755, 180);
            this.dataGridView1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(27, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 201);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar,";
            // 
            // pERSONEL_TAKİP_LİSTDataSet
            // 
            this.pERSONEL_TAKİP_LİSTDataSet.DataSetName = "PERSONEL_TAKİP_LİSTDataSet";
            this.pERSONEL_TAKİP_LİSTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonBindingSource
            // 
            this.tblPersonBindingSource.DataMember = "tbl_Person";
            this.tblPersonBindingSource.DataSource = this.pERSONEL_TAKİP_LİSTDataSet;
            // 
            // tbl_PersonTableAdapter
            // 
            this.tbl_PersonTableAdapter.ClearBeforeFill = true;
            // 
            // personelDDataGridViewTextBoxColumn
            // 
            this.personelDDataGridViewTextBoxColumn.DataPropertyName = "PersonelD";
            this.personelDDataGridViewTextBoxColumn.HeaderText = "PersonelD";
            this.personelDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDDataGridViewTextBoxColumn.Name = "personelDDataGridViewTextBoxColumn";
            this.personelDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelNameDataGridViewTextBoxColumn
            // 
            this.personelNameDataGridViewTextBoxColumn.DataPropertyName = "PersonelName";
            this.personelNameDataGridViewTextBoxColumn.HeaderText = "PersonelName";
            this.personelNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelNameDataGridViewTextBoxColumn.Name = "personelNameDataGridViewTextBoxColumn";
            this.personelNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelCityDataGridViewTextBoxColumn
            // 
            this.personelCityDataGridViewTextBoxColumn.DataPropertyName = "PersonelCity";
            this.personelCityDataGridViewTextBoxColumn.HeaderText = "PersonelCity";
            this.personelCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelCityDataGridViewTextBoxColumn.Name = "personelCityDataGridViewTextBoxColumn";
            this.personelCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelWageDataGridViewTextBoxColumn
            // 
            this.personelWageDataGridViewTextBoxColumn.DataPropertyName = "PersonelWage";
            this.personelWageDataGridViewTextBoxColumn.HeaderText = "PersonelWage";
            this.personelWageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelWageDataGridViewTextBoxColumn.Name = "personelWageDataGridViewTextBoxColumn";
            this.personelWageDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelStatuDataGridViewTextBoxColumn
            // 
            this.personelStatuDataGridViewTextBoxColumn.DataPropertyName = "PersonelStatu";
            this.personelStatuDataGridViewTextBoxColumn.HeaderText = "PersonelStatu";
            this.personelStatuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelStatuDataGridViewTextBoxColumn.Name = "personelStatuDataGridViewTextBoxColumn";
            this.personelStatuDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelJobDataGridViewTextBoxColumn
            // 
            this.personelJobDataGridViewTextBoxColumn.DataPropertyName = "PersonelJob";
            this.personelJobDataGridViewTextBoxColumn.HeaderText = "PersonelJob";
            this.personelJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelJobDataGridViewTextBoxColumn.Name = "personelJobDataGridViewTextBoxColumn";
            this.personelJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.mskd_maas);
            this.Controls.Add(this.txt_Meslek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_sehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pERSONEL_TAKİP_LİSTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Meslek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskd_maas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private PERSONEL_TAKİP_LİSTDataSet pERSONEL_TAKİP_LİSTDataSet;
        private System.Windows.Forms.BindingSource tblPersonBindingSource;
        private PERSONEL_TAKİP_LİSTDataSetTableAdapters.tbl_PersonTableAdapter tbl_PersonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelWageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelStatuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelJobDataGridViewTextBoxColumn;
    }
}

