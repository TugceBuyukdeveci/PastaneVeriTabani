namespace ödev
{
    partial class Form3
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pASTANEİSLETMECİLİĞİDataSet17 = new ödev.PASTANEİSLETMECİLİĞİDataSet17();
            this.mASALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASALARTableAdapter = new ödev.PASTANEİSLETMECİLİĞİDataSet17TableAdapters.MASALARTableAdapter();
            this.masaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASTANEİSLETMECİLİĞİDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASALARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masaidDataGridViewTextBoxColumn,
            this.masaAdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.mASALARBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(243, 292);
            this.dataGridView3.TabIndex = 0;
            // 
            // pASTANEİSLETMECİLİĞİDataSet17
            // 
            this.pASTANEİSLETMECİLİĞİDataSet17.DataSetName = "PASTANEİSLETMECİLİĞİDataSet17";
            this.pASTANEİSLETMECİLİĞİDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASALARBindingSource
            // 
            this.mASALARBindingSource.DataMember = "MASALAR";
            this.mASALARBindingSource.DataSource = this.pASTANEİSLETMECİLİĞİDataSet17;
            // 
            // mASALARTableAdapter
            // 
            this.mASALARTableAdapter.ClearBeforeFill = true;
            // 
            // masaidDataGridViewTextBoxColumn
            // 
            this.masaidDataGridViewTextBoxColumn.DataPropertyName = "Masa_id";
            this.masaidDataGridViewTextBoxColumn.HeaderText = "Masa_id";
            this.masaidDataGridViewTextBoxColumn.Name = "masaidDataGridViewTextBoxColumn";
            this.masaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masaAdDataGridViewTextBoxColumn
            // 
            this.masaAdDataGridViewTextBoxColumn.DataPropertyName = "Masa_Ad";
            this.masaAdDataGridViewTextBoxColumn.HeaderText = "Masa_Ad";
            this.masaAdDataGridViewTextBoxColumn.Name = "masaAdDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Masa Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masa Ad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Masa Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Masa Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(348, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 379);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASTANEİSLETMECİLİĞİDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASALARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private PASTANEİSLETMECİLİĞİDataSet17 pASTANEİSLETMECİLİĞİDataSet17;
        private System.Windows.Forms.BindingSource mASALARBindingSource;
        private PASTANEİSLETMECİLİĞİDataSet17TableAdapters.MASALARTableAdapter mASALARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}