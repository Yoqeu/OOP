using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class RoomInfoForm : Form
    {
        public RoomInfoForm()
        {
            InitializeComponent();
        }

        private void RoomInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet4.ReservedRooms". При необходимости она может быть перемещена или удалена.
            this.reservedRoomsTableAdapter.Fill(this.yoqesDataSet4.ReservedRooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet4.NotRooms". При необходимости она может быть перемещена или удалена.
            this.notRoomsTableAdapter.Fill(this.yoqesDataSet4.NotRooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet4.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter1.Fill(this.yoqesDataSet4.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet3.NotRooms". При необходимости она может быть перемещена или удалена.
            this.notRoomsTableAdapter.Fill(this.yoqesDataSet3.NotRooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet3.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter1.Fill(this.yoqesDataSet3.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet2.ReservedRooms". При необходимости она может быть перемещена или удалена.
            this.reservedRoomsTableAdapter.Fill(this.yoqesDataSet2.ReservedRooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet2.NotRooms". При необходимости она может быть перемещена или удалена.
            this.notRoomsTableAdapter.Fill(this.yoqesDataSet2.NotRooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet1.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter1.Fill(this.yoqesDataSet1.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter1.Fill(this.yoqesDataSet1.Rooms);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Enabled = true;
            form1.ShowDialog();
            this.Show();
            Close();
        }

        private void RoomInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataSourceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DataSourceBox.SelectedIndex == 0)
            {
                RoomInfoGrid.DataSource = roomsBindingSource7;
                roomsTableAdapter1.Fill(yoqesDataSet4.Rooms);
                //roomsTableAdapter.Fill(yoqesDataSet1.Rooms);
                RoomInfoGrid.Refresh();
            }
            else if(DataSourceBox.SelectedIndex == 1)
            {
                RoomInfoGrid.DataSource = notRoomsBindingSource5;
                notRoomsTableAdapter.Fill(yoqesDataSet4.NotRooms);
                RoomInfoGrid.Refresh();
            }
            else if(DataSourceBox.SelectedIndex == 2)
            {
                RoomInfoGrid.DataSource = reservedRoomsBindingSource2;
                reservedRoomsTableAdapter.Fill(yoqesDataSet4.ReservedRooms);
                RoomInfoGrid.Refresh();
            }
        }
    }
}
