namespace diplom_test
{
    partial class Form10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arenda1DataSet = new diplom_test.Arenda1DataSet();
            this.помещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.помещениеTableAdapter = new diplom_test.Arenda1DataSetTableAdapters.ПомещениеTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАдресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.краткоеОписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодХарактеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЕдиницыИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПрайсЛистаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЗданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenda1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодАдресаDataGridViewTextBoxColumn,
            this.краткоеОписаниеDataGridViewTextBoxColumn,
            this.кодХарактеристикиDataGridViewTextBoxColumn,
            this.кодЕдиницыИзмеренияDataGridViewTextBoxColumn,
            this.кодПрайсЛистаDataGridViewTextBoxColumn,
            this.кодЗданияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.помещениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // arenda1DataSet
            // 
            this.arenda1DataSet.DataSetName = "Arenda1DataSet";
            this.arenda1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // помещениеBindingSource
            // 
            this.помещениеBindingSource.DataMember = "Помещение";
            this.помещениеBindingSource.DataSource = this.arenda1DataSet;
            // 
            // помещениеTableAdapter
            // 
            this.помещениеTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // кодАдресаDataGridViewTextBoxColumn
            // 
            this.кодАдресаDataGridViewTextBoxColumn.DataPropertyName = "Код адреса";
            this.кодАдресаDataGridViewTextBoxColumn.HeaderText = "Код адреса";
            this.кодАдресаDataGridViewTextBoxColumn.Name = "кодАдресаDataGridViewTextBoxColumn";
            // 
            // краткоеОписаниеDataGridViewTextBoxColumn
            // 
            this.краткоеОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Краткое описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.HeaderText = "Краткое описание";
            this.краткоеОписаниеDataGridViewTextBoxColumn.Name = "краткоеОписаниеDataGridViewTextBoxColumn";
            // 
            // кодХарактеристикиDataGridViewTextBoxColumn
            // 
            this.кодХарактеристикиDataGridViewTextBoxColumn.DataPropertyName = "Код характеристики";
            this.кодХарактеристикиDataGridViewTextBoxColumn.HeaderText = "Код характеристики";
            this.кодХарактеристикиDataGridViewTextBoxColumn.Name = "кодХарактеристикиDataGridViewTextBoxColumn";
            // 
            // кодЕдиницыИзмеренияDataGridViewTextBoxColumn
            // 
            this.кодЕдиницыИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Код единицы измерения";
            this.кодЕдиницыИзмеренияDataGridViewTextBoxColumn.HeaderText = "Код единицы измерения";
            this.кодЕдиницыИзмеренияDataGridViewTextBoxColumn.Name = "кодЕдиницыИзмеренияDataGridViewTextBoxColumn";
            // 
            // кодПрайсЛистаDataGridViewTextBoxColumn
            // 
            this.кодПрайсЛистаDataGridViewTextBoxColumn.DataPropertyName = "Код прайс листа";
            this.кодПрайсЛистаDataGridViewTextBoxColumn.HeaderText = "Код прайс листа";
            this.кодПрайсЛистаDataGridViewTextBoxColumn.Name = "кодПрайсЛистаDataGridViewTextBoxColumn";
            // 
            // кодЗданияDataGridViewTextBoxColumn
            // 
            this.кодЗданияDataGridViewTextBoxColumn.DataPropertyName = "Код здания";
            this.кодЗданияDataGridViewTextBoxColumn.HeaderText = "Код здания";
            this.кодЗданияDataGridViewTextBoxColumn.Name = "кодЗданияDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Помещения";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenda1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Arenda1DataSet arenda1DataSet;
        private System.Windows.Forms.BindingSource помещениеBindingSource;
        private Arenda1DataSetTableAdapters.ПомещениеTableAdapter помещениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАдресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn краткоеОписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодХарактеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЕдиницыИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПрайсЛистаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}