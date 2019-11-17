namespace diplom_test
{
    partial class Form8
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПомещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодРолиСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорАрендыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arenda1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arenda1DataSet = new diplom_test.Arenda1DataSet();
            this.помещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.помещениеTableAdapter = new diplom_test.Arenda1DataSetTableAdapters.ПомещениеTableAdapter();
            this.договор_арендыTableAdapter = new diplom_test.Arenda1DataSetTableAdapters.Договор_арендыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорАрендыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenda1DataSetBindingSource)).BeginInit();
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
            this.датаЗаключенияDataGridViewTextBoxColumn,
            this.кодПомещенияDataGridViewTextBoxColumn,
            this.кодРолиСотрудникаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договорАрендыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // датаЗаключенияDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения";
            this.датаЗаключенияDataGridViewTextBoxColumn.HeaderText = "Дата заключения";
            this.датаЗаключенияDataGridViewTextBoxColumn.Name = "датаЗаключенияDataGridViewTextBoxColumn";
            // 
            // кодПомещенияDataGridViewTextBoxColumn
            // 
            this.кодПомещенияDataGridViewTextBoxColumn.DataPropertyName = "Код помещения";
            this.кодПомещенияDataGridViewTextBoxColumn.HeaderText = "Код помещения";
            this.кодПомещенияDataGridViewTextBoxColumn.Name = "кодПомещенияDataGridViewTextBoxColumn";
            // 
            // кодРолиСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодРолиСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код роли сотрудника";
            this.кодРолиСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код роли сотрудника";
            this.кодРолиСотрудникаDataGridViewTextBoxColumn.Name = "кодРолиСотрудникаDataGridViewTextBoxColumn";
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            // 
            // договорАрендыBindingSource
            // 
            this.договорАрендыBindingSource.DataMember = "Договор аренды";
            this.договорАрендыBindingSource.DataSource = this.arenda1DataSetBindingSource;
            // 
            // arenda1DataSetBindingSource
            // 
            this.arenda1DataSetBindingSource.DataSource = this.arenda1DataSet;
            this.arenda1DataSetBindingSource.Position = 0;
            // 
            // arenda1DataSet
            // 
            this.arenda1DataSet.DataSetName = "Arenda1DataSet";
            this.arenda1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // помещениеBindingSource
            // 
            this.помещениеBindingSource.DataMember = "Помещение";
            this.помещениеBindingSource.DataSource = this.arenda1DataSetBindingSource;
            // 
            // помещениеTableAdapter
            // 
            this.помещениеTableAdapter.ClearBeforeFill = true;
            // 
            // договор_арендыTableAdapter
            // 
            this.договор_арендыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Сделки";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорАрендыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenda1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenda1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource arenda1DataSetBindingSource;
        private Arenda1DataSet arenda1DataSet;
        private System.Windows.Forms.BindingSource помещениеBindingSource;
        private Arenda1DataSetTableAdapters.ПомещениеTableAdapter помещениеTableAdapter;
        private System.Windows.Forms.BindingSource договорАрендыBindingSource;
        private Arenda1DataSetTableAdapters.Договор_арендыTableAdapter договор_арендыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПомещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРолиСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}