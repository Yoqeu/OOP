using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class ReservedForm : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public ReservedForm()
        {
            InitializeComponent();
        }

        private void ReservForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet1.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet1.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet.Rooms);

        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = FromDatePicker.Value;
            DateTime date2 = new DateTime();
            date2 = ToDatePicker.Value;
            TimeSpan days = new TimeSpan();
            days = date2.Subtract(date1);
            int days1 = days.Days;
            if (days1 < 0)
            {
                MessageBox.Show("Incorrect Date");
                return;
            }
            int Num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            con = new SqlConnection(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            //DataContext db = new DataContext(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO ReservedRooms (Number, From_Date, To_Date, Id, Comfort, Capacity, Price, Expense) VALUES (@Number, @From_Date, @To_Date, @Id, @Comfort, @Capacity, @Price, @Expense)", con);
            cmd.Parameters.AddWithValue("@Number", Num);
            cmd.Parameters.AddWithValue("@From_Date", FromDatePicker.Value);
            cmd.Parameters.AddWithValue("@To_Date", ToDatePicker.Value);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@Comfort", dataGridView1.CurrentRow.Cells[1].Value);
            cmd.Parameters.AddWithValue("@Capacity", dataGridView1.CurrentRow.Cells[2].Value);
            cmd.Parameters.AddWithValue("@Price", dataGridView1.CurrentRow.Cells[3].Value);
            cmd.Parameters.AddWithValue("@Expense", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.ExecuteNonQuery();
            DateTime today = new DateTime();
            today = DateTime.Today;
            TimeSpan tst = new TimeSpan();
            tst = today.Subtract(date1);
            int tstint = tst.Days;
            if(tstint == 0 || tstint > 0)
            {
                string s = dataGridView1.CurrentCell.Value.ToString();
                int selected_rows = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string command = "DELETE FROM Rooms WHERE (Id=" + Convert.ToInt32(s) + ");";
                cmd = new SqlCommand(command, con);
                cmd.ExecuteNonQuery();
                roomsTableAdapter.Fill(yoqesDataSet1.Rooms);
                dataGridView1.Refresh();
            }
            con.Close();

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
    }
}
