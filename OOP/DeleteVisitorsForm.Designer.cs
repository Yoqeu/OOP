namespace OOP
{
    partial class DeleteVisitorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteVisitorsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitorsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet1 = new OOP.YoqesDataSet();
            this.visitorsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet = new OOP.YoqesDataSet();
            this.visitorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.visitorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorsTableAdapter = new OOP.YoqesDataSetTableAdapters.VisitorsTableAdapter();
            this.TaxBox = new CueTextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jacuzziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allIncludeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comfort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn,
            this.leaveDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.barDataGridViewTextBoxColumn,
            this.cleaningDataGridViewTextBoxColumn,
            this.foodServiceDataGridViewTextBoxColumn,
            this.jacuzziDataGridViewTextBoxColumn,
            this.allIncludeDataGridViewTextBoxColumn,
            this.vIPDataGridViewTextBoxColumn,
            this.Comfort,
            this.Capacity,
            this.Price,
            this.Expense});
            this.dataGridView1.DataSource = this.visitorsBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(863, 544);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // visitorsBindingSource4
            // 
            this.visitorsBindingSource4.DataMember = "Visitors";
            this.visitorsBindingSource4.DataSource = this.yoqesDataSet1;
            // 
            // yoqesDataSet1
            // 
            this.yoqesDataSet1.DataSetName = "YoqesDataSet";
            this.yoqesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorsBindingSource3
            // 
            this.visitorsBindingSource3.DataMember = "Visitors";
            this.visitorsBindingSource3.DataSource = this.yoqesDataSet;
            // 
            // yoqesDataSet
            // 
            this.yoqesDataSet.DataSetName = "YoqesDataSet";
            this.yoqesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorsBindingSource2
            // 
            this.visitorsBindingSource2.DataMember = "Visitors";
            this.visitorsBindingSource2.DataSource = this.yoqesDataSet;
            // 
            // visitorsBindingSource1
            // 
            this.visitorsBindingSource1.DataMember = "Visitors";
            this.visitorsBindingSource1.DataSource = this.yoqesDataSet;
            // 
            // visitorsBindingSource
            // 
            this.visitorsBindingSource.DataMember = "Visitors";
            this.visitorsBindingSource.DataSource = this.yoqesDataSet;
            // 
            // visitorsTableAdapter
            // 
            this.visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // TaxBox
            // 
            this.TaxBox.Cue = "Tax";
            this.TaxBox.Location = new System.Drawing.Point(895, 15);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.Size = new System.Drawing.Size(105, 22);
            this.TaxBox.TabIndex = 1;
            this.TaxBox.TextChanged += new System.EventHandler(this.TaxBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1021, 525);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 31);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(905, 525);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(95, 31);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 109;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "Second_Name";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second_Name";
            this.secondNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.secondNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymicDataGridViewTextBoxColumn.Width = 107;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Visible = false;
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room_Number";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn.Width = 132;
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "Enter_Date";
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "Enter_Date";
            this.enterDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            this.enterDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.enterDateDataGridViewTextBoxColumn.Width = 109;
            // 
            // leaveDateDataGridViewTextBoxColumn
            // 
            this.leaveDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.leaveDateDataGridViewTextBoxColumn.DataPropertyName = "Leave_Date";
            this.leaveDateDataGridViewTextBoxColumn.HeaderText = "Leave_Date";
            this.leaveDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leaveDateDataGridViewTextBoxColumn.Name = "leaveDateDataGridViewTextBoxColumn";
            this.leaveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.leaveDateDataGridViewTextBoxColumn.Width = 114;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 109;
            // 
            // barDataGridViewTextBoxColumn
            // 
            this.barDataGridViewTextBoxColumn.DataPropertyName = "Bar";
            this.barDataGridViewTextBoxColumn.HeaderText = "Bar";
            this.barDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barDataGridViewTextBoxColumn.Name = "barDataGridViewTextBoxColumn";
            this.barDataGridViewTextBoxColumn.ReadOnly = true;
            this.barDataGridViewTextBoxColumn.Visible = false;
            this.barDataGridViewTextBoxColumn.Width = 125;
            // 
            // cleaningDataGridViewTextBoxColumn
            // 
            this.cleaningDataGridViewTextBoxColumn.DataPropertyName = "Cleaning";
            this.cleaningDataGridViewTextBoxColumn.HeaderText = "Cleaning";
            this.cleaningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cleaningDataGridViewTextBoxColumn.Name = "cleaningDataGridViewTextBoxColumn";
            this.cleaningDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleaningDataGridViewTextBoxColumn.Visible = false;
            this.cleaningDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodServiceDataGridViewTextBoxColumn
            // 
            this.foodServiceDataGridViewTextBoxColumn.DataPropertyName = "Food_Service";
            this.foodServiceDataGridViewTextBoxColumn.HeaderText = "Food_Service";
            this.foodServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodServiceDataGridViewTextBoxColumn.Name = "foodServiceDataGridViewTextBoxColumn";
            this.foodServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodServiceDataGridViewTextBoxColumn.Visible = false;
            this.foodServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // jacuzziDataGridViewTextBoxColumn
            // 
            this.jacuzziDataGridViewTextBoxColumn.DataPropertyName = "Jacuzzi";
            this.jacuzziDataGridViewTextBoxColumn.HeaderText = "Jacuzzi";
            this.jacuzziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jacuzziDataGridViewTextBoxColumn.Name = "jacuzziDataGridViewTextBoxColumn";
            this.jacuzziDataGridViewTextBoxColumn.ReadOnly = true;
            this.jacuzziDataGridViewTextBoxColumn.Visible = false;
            this.jacuzziDataGridViewTextBoxColumn.Width = 125;
            // 
            // allIncludeDataGridViewTextBoxColumn
            // 
            this.allIncludeDataGridViewTextBoxColumn.DataPropertyName = "All_Include";
            this.allIncludeDataGridViewTextBoxColumn.HeaderText = "All_Include";
            this.allIncludeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allIncludeDataGridViewTextBoxColumn.Name = "allIncludeDataGridViewTextBoxColumn";
            this.allIncludeDataGridViewTextBoxColumn.ReadOnly = true;
            this.allIncludeDataGridViewTextBoxColumn.Visible = false;
            this.allIncludeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vIPDataGridViewTextBoxColumn
            // 
            this.vIPDataGridViewTextBoxColumn.DataPropertyName = "VIP";
            this.vIPDataGridViewTextBoxColumn.HeaderText = "VIP";
            this.vIPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vIPDataGridViewTextBoxColumn.Name = "vIPDataGridViewTextBoxColumn";
            this.vIPDataGridViewTextBoxColumn.ReadOnly = true;
            this.vIPDataGridViewTextBoxColumn.Visible = false;
            this.vIPDataGridViewTextBoxColumn.Width = 125;
            // 
            // Comfort
            // 
            this.Comfort.DataPropertyName = "Comfort";
            this.Comfort.HeaderText = "Comfort";
            this.Comfort.MinimumWidth = 6;
            this.Comfort.Name = "Comfort";
            this.Comfort.ReadOnly = true;
            this.Comfort.Visible = false;
            this.Comfort.Width = 125;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Visible = false;
            this.Capacity.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            this.Price.Width = 125;
            // 
            // Expense
            // 
            this.Expense.DataPropertyName = "Expense";
            this.Expense.HeaderText = "Expense";
            this.Expense.MinimumWidth = 6;
            this.Expense.Name = "Expense";
            this.Expense.ReadOnly = true;
            this.Expense.Visible = false;
            this.Expense.Width = 125;
            // 
            // RateBox
            // 
            this.RateBox.FormattingEnabled = true;
            this.RateBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RateBox.Location = new System.Drawing.Point(895, 68);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(105, 24);
            this.RateBox.TabIndex = 4;
            this.RateBox.SelectedIndexChanged += new System.EventHandler(this.RateBox_SelectedIndexChanged);
            // 
            // DeleteVisitorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 571);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TaxBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteVisitorsForm";
            this.Text = "Delete Visitors";
            this.Load += new System.EventHandler(this.DeleteVisitorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YoqesDataSet yoqesDataSet;
        private System.Windows.Forms.BindingSource visitorsBindingSource;
        private YoqesDataSetTableAdapters.VisitorsTableAdapter visitorsTableAdapter;
        private CueTextBox TaxBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.BindingSource visitorsBindingSource1;
        private System.Windows.Forms.BindingSource visitorsBindingSource2;
        private System.Windows.Forms.BindingSource visitorsBindingSource3;
        private YoqesDataSet yoqesDataSet1;
        private System.Windows.Forms.BindingSource visitorsBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jacuzziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allIncludeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comfort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense;
        private System.Windows.Forms.ComboBox RateBox;
    }
}