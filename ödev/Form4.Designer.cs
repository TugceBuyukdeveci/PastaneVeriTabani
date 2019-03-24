namespace ödev
{
    partial class Form4
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.pASTANEİSLETMECİLİĞİDataSet18 = new ödev.PASTANEİSLETMECİLİĞİDataSet18();
            this.aLINANMALLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLINANMALLARTableAdapter = new ödev.PASTANEİSLETMECİLİĞİDataSet18TableAdapters.ALINANMALLARTableAdapter();
            this.alinanmalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmalAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmalMikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmalTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmalSKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASTANEİSLETMECİLİĞİDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLINANMALLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alinanmalidDataGridViewTextBoxColumn,
            this.alinanmalAdDataGridViewTextBoxColumn,
            this.alinanmalMikDataGridViewTextBoxColumn,
            this.alinanmalTarihDataGridViewTextBoxColumn,
            this.alinanmalSKTDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.aLINANMALLARBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(13, 13);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(554, 363);
            this.dataGridView4.TabIndex = 0;
            // 
            // pASTANEİSLETMECİLİĞİDataSet18
            // 
            this.pASTANEİSLETMECİLİĞİDataSet18.DataSetName = "PASTANEİSLETMECİLİĞİDataSet18";
            this.pASTANEİSLETMECİLİĞİDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLINANMALLARBindingSource
            // 
            this.aLINANMALLARBindingSource.DataMember = "ALINANMALLAR";
            this.aLINANMALLARBindingSource.DataSource = this.pASTANEİSLETMECİLİĞİDataSet18;
            // 
            // aLINANMALLARTableAdapter
            // 
            this.aLINANMALLARTableAdapter.ClearBeforeFill = true;
            // 
            // alinanmalidDataGridViewTextBoxColumn
            // 
            this.alinanmalidDataGridViewTextBoxColumn.DataPropertyName = "Alinanmal_id";
            this.alinanmalidDataGridViewTextBoxColumn.HeaderText = "Alinanmal_id";
            this.alinanmalidDataGridViewTextBoxColumn.Name = "alinanmalidDataGridViewTextBoxColumn";
            this.alinanmalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alinanmalAdDataGridViewTextBoxColumn
            // 
            this.alinanmalAdDataGridViewTextBoxColumn.DataPropertyName = "Alinanmal_Ad";
            this.alinanmalAdDataGridViewTextBoxColumn.HeaderText = "Alinanmal_Ad";
            this.alinanmalAdDataGridViewTextBoxColumn.Name = "alinanmalAdDataGridViewTextBoxColumn";
            // 
            // alinanmalMikDataGridViewTextBoxColumn
            // 
            this.alinanmalMikDataGridViewTextBoxColumn.DataPropertyName = "Alinanmal_Mik";
            this.alinanmalMikDataGridViewTextBoxColumn.HeaderText = "Alinanmal_Mik";
            this.alinanmalMikDataGridViewTextBoxColumn.Name = "alinanmalMikDataGridViewTextBoxColumn";
            // 
            // alinanmalTarihDataGridViewTextBoxColumn
            // 
            this.alinanmalTarihDataGridViewTextBoxColumn.DataPropertyName = "Alinanmal_Tarih";
            this.alinanmalTarihDataGridViewTextBoxColumn.HeaderText = "Alinanmal_Tarih";
            this.alinanmalTarihDataGridViewTextBoxColumn.Name = "alinanmalTarihDataGridViewTextBoxColumn";
            // 
            // alinanmalSKTDataGridViewTextBoxColumn
            // 
            this.alinanmalSKTDataGridViewTextBoxColumn.DataPropertyName = "Alinanmal_SKT";
            this.alinanmalSKTDataGridViewTextBoxColumn.HeaderText = "Alinanmal_SKT";
            this.alinanmalSKTDataGridViewTextBoxColumn.Name = "alinanmalSKTDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(732, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(593, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(732, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Son Kullanma Tarihi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ürün Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(593, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(738, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(593, 218);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(738, 218);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(670, 267);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ürün Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürün Adet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alım Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Son Kullanma Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ürün No";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(643, 325);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Ürün Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASTANEİSLETMECİLİĞİDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLINANMALLARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private PASTANEİSLETMECİLİĞİDataSet18 pASTANEİSLETMECİLİĞİDataSet18;
        private System.Windows.Forms.BindingSource aLINANMALLARBindingSource;
        private PASTANEİSLETMECİLİĞİDataSet18TableAdapters.ALINANMALLARTableAdapter aLINANMALLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalMikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalSKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button3;
    }
}