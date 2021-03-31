namespace OOP
{
    partial class RoomInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfoForm));
            this.RoomInfoGrid = new System.Windows.Forms.DataGridView();
            this.reservedRoomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet2 = new OOP.YoqesDataSet();
            this.notRoomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet1 = new OOP.YoqesDataSet();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.roomsTableAdapter1 = new OOP.YoqesDataSetTableAdapters.RoomsTableAdapter();
            this.notRoomsTableAdapter = new OOP.YoqesDataSetTableAdapters.NotRoomsTableAdapter();
            this.DataSourceBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.reservedRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservedRoomsTableAdapter = new OOP.YoqesDataSetTableAdapters.ReservedRoomsTableAdapter();
            this.yoqesDataSet3 = new OOP.YoqesDataSet();
            this.roomsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.notRoomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.notRoomsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.notRoomsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yoqesDataSet4 = new OOP.YoqesDataSet();
            this.roomsBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.notRoomsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.reservedRoomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomInfoGrid
            // 
            this.RoomInfoGrid.AllowUserToAddRows = false;
            this.RoomInfoGrid.AllowUserToDeleteRows = false;
            this.RoomInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomInfoGrid.Location = new System.Drawing.Point(24, 12);
            this.RoomInfoGrid.Name = "RoomInfoGrid";
            this.RoomInfoGrid.ReadOnly = true;
            this.RoomInfoGrid.RowHeadersWidth = 51;
            this.RoomInfoGrid.RowTemplate.Height = 24;
            this.RoomInfoGrid.Size = new System.Drawing.Size(816, 456);
            this.RoomInfoGrid.TabIndex = 0;
            this.RoomInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomInfoGrid_CellContentClick);
            // 
            // reservedRoomsBindingSource1
            // 
            this.reservedRoomsBindingSource1.DataMember = "ReservedRooms";
            this.reservedRoomsBindingSource1.DataSource = this.yoqesDataSet2;
            // 
            // yoqesDataSet2
            // 
            this.yoqesDataSet2.DataSetName = "YoqesDataSet";
            this.yoqesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notRoomsBindingSource1
            // 
            this.notRoomsBindingSource1.DataMember = "NotRooms";
            this.notRoomsBindingSource1.DataSource = this.yoqesDataSet2;
            // 
            // notRoomsBindingSource
            // 
            this.notRoomsBindingSource.DataMember = "NotRooms";
            this.notRoomsBindingSource.DataSource = this.yoqesDataSet2;
            // 
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "Rooms";
            this.roomsBindingSource2.DataSource = this.yoqesDataSet1;
            // 
            // yoqesDataSet1
            // 
            this.yoqesDataSet1.DataSetName = "YoqesDataSet";
            this.yoqesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.yoqesDataSet1;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(865, 440);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(108, 28);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // notRoomsTableAdapter
            // 
            this.notRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // DataSourceBox
            // 
            this.DataSourceBox.FormattingEnabled = true;
            this.DataSourceBox.Items.AddRange(new object[] {
            "Free Rooms",
            "Busy Rooms",
            "Reserved Rooms"});
            this.DataSourceBox.Location = new System.Drawing.Point(865, 12);
            this.DataSourceBox.Name = "DataSourceBox";
            this.DataSourceBox.Size = new System.Drawing.Size(108, 24);
            this.DataSourceBox.TabIndex = 2;
            this.DataSourceBox.SelectedIndexChanged += new System.EventHandler(this.DataSourceBox_SelectedIndexChanged);
            // 
            // roomsBindingSource3
            // 
            this.roomsBindingSource3.DataMember = "Rooms";
            this.roomsBindingSource3.DataSource = this.yoqesDataSet2;
            // 
            // reservedRoomsBindingSource
            // 
            this.reservedRoomsBindingSource.DataMember = "ReservedRooms";
            this.reservedRoomsBindingSource.DataSource = this.yoqesDataSet2;
            // 
            // reservedRoomsTableAdapter
            // 
            this.reservedRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // yoqesDataSet3
            // 
            this.yoqesDataSet3.DataSetName = "YoqesDataSet";
            this.yoqesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource4
            // 
            this.roomsBindingSource4.DataMember = "Rooms";
            this.roomsBindingSource4.DataSource = this.yoqesDataSet3;
            // 
            // notRoomsBindingSource2
            // 
            this.notRoomsBindingSource2.DataMember = "NotRooms";
            this.notRoomsBindingSource2.DataSource = this.yoqesDataSet3;
            // 
            // roomsBindingSource5
            // 
            this.roomsBindingSource5.DataMember = "Rooms";
            this.roomsBindingSource5.DataSource = this.yoqesDataSet2;
            // 
            // notRoomsBindingSource3
            // 
            this.notRoomsBindingSource3.DataMember = "NotRooms";
            this.notRoomsBindingSource3.DataSource = this.yoqesDataSet2;
            // 
            // roomsBindingSource6
            // 
            this.roomsBindingSource6.DataMember = "Rooms";
            this.roomsBindingSource6.DataSource = this.yoqesDataSet2;
            // 
            // notRoomsBindingSource4
            // 
            this.notRoomsBindingSource4.DataMember = "NotRooms";
            this.notRoomsBindingSource4.DataSource = this.yoqesDataSet2;
            // 
            // yoqesDataSet2BindingSource
            // 
            this.yoqesDataSet2BindingSource.DataSource = this.yoqesDataSet2;
            this.yoqesDataSet2BindingSource.Position = 0;
            // 
            // yoqesDataSet4
            // 
            this.yoqesDataSet4.DataSetName = "YoqesDataSet";
            this.yoqesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource7
            // 
            this.roomsBindingSource7.DataMember = "Rooms";
            this.roomsBindingSource7.DataSource = this.yoqesDataSet4;
            // 
            // notRoomsBindingSource5
            // 
            this.notRoomsBindingSource5.DataMember = "NotRooms";
            this.notRoomsBindingSource5.DataSource = this.yoqesDataSet4;
            // 
            // reservedRoomsBindingSource2
            // 
            this.reservedRoomsBindingSource2.DataMember = "ReservedRooms";
            this.reservedRoomsBindingSource2.DataSource = this.yoqesDataSet4;
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.DataSourceBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RoomInfoGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomInfoForm";
            this.Text = "Room Info";
            this.Load += new System.EventHandler(this.RoomInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoqesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notRoomsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedRoomsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomInfoGrid;
        private YoqesDataSet yoqesDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private YoqesDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comfortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackButton;
        private YoqesDataSet yoqesDataSet1;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private YoqesDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private YoqesDataSet yoqesDataSet2;
        private System.Windows.Forms.BindingSource notRoomsBindingSource;
        private YoqesDataSetTableAdapters.NotRoomsTableAdapter notRoomsTableAdapter;
        private System.Windows.Forms.ComboBox DataSourceBox;
        private System.Windows.Forms.BindingSource roomsBindingSource3;
        private System.Windows.Forms.BindingSource notRoomsBindingSource1;
        private System.Windows.Forms.BindingSource reservedRoomsBindingSource;
        private YoqesDataSetTableAdapters.ReservedRoomsTableAdapter reservedRoomsTableAdapter;
        private YoqesDataSet yoqesDataSet3;
        private System.Windows.Forms.BindingSource roomsBindingSource4;
        private System.Windows.Forms.BindingSource notRoomsBindingSource2;
        private System.Windows.Forms.BindingSource roomsBindingSource5;
        private System.Windows.Forms.BindingSource notRoomsBindingSource3;
        private System.Windows.Forms.BindingSource reservedRoomsBindingSource1;
        private System.Windows.Forms.BindingSource roomsBindingSource6;
        private System.Windows.Forms.BindingSource notRoomsBindingSource4;
        private System.Windows.Forms.BindingSource yoqesDataSet2BindingSource;
        private YoqesDataSet yoqesDataSet4;
        private System.Windows.Forms.BindingSource roomsBindingSource7;
        private System.Windows.Forms.BindingSource notRoomsBindingSource5;
        private System.Windows.Forms.BindingSource reservedRoomsBindingSource2;
    }
}