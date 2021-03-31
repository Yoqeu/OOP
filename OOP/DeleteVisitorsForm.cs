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
    public partial class DeleteVisitorsForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public DeleteVisitorsForm()
        {
            InitializeComponent();
        }

        private void DeleteVisitorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet1.Visitors". При необходимости она может быть перемещена или удалена.
            this.visitorsTableAdapter.Fill(this.yoqesDataSet1.Visitors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet.Visitors". При необходимости она может быть перемещена или удалена.
            this.visitorsTableAdapter.Fill(this.yoqesDataSet.Visitors);

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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            //DataContext db = new DataContext(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Rooms (Id, Comfort, Capacity, Price, Number, Expense) " +
                "VALUES (@Id, @Comfort, @Capacity, @Price, @Number, @Expense)", con);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.Parameters.AddWithValue("@Comfort", dataGridView1.CurrentRow.Cells[15].Value);
            cmd.Parameters.AddWithValue("@Capacity", dataGridView1.CurrentRow.Cells[16].Value);
            cmd.Parameters.AddWithValue("@Price", dataGridView1.CurrentRow.Cells[17].Value);
            cmd.Parameters.AddWithValue("@Number", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.Parameters.AddWithValue("@Expense", dataGridView1.CurrentRow.Cells[18].Value);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO PermVisitors (Id, First_Name, Second_Name, Patronymic, Comment, " +
                "Room_Number, Total_Price, Tax, Enter_Date, Leave_Date, Actual_Leave_Date, Rate)" +
                " VALUES (@Id, @First_Name, @Second_Name, @Patronymic, @Comment, @Room_Number, @Total_Price, " +
                "@Tax, @Enter_Date, @Leave_Date, @Actual_Leave_Date, @Rate)", con);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@First_Name", dataGridView1.CurrentRow.Cells[1].Value);
            cmd.Parameters.AddWithValue("@Second_Name", dataGridView1.CurrentRow.Cells[2].Value);
            cmd.Parameters.AddWithValue("@Patronymic", dataGridView1.CurrentRow.Cells[3].Value);
            cmd.Parameters.AddWithValue("@Comment", dataGridView1.CurrentRow.Cells[4].Value);
            cmd.Parameters.AddWithValue("@Room_Number", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.Parameters.AddWithValue("@Enter_Date", dataGridView1.CurrentRow.Cells[6].Value);
            cmd.Parameters.AddWithValue("@Leave_Date", dataGridView1.CurrentRow.Cells[7].Value);
            cmd.Parameters.AddWithValue("@Total_Price", dataGridView1.CurrentRow.Cells[8].Value);
            if (TaxBox.Text == null)
                TaxBox.Text = "0";
            cmd.Parameters.AddWithValue("@Tax", TaxBox.Text);
            cmd.Parameters.AddWithValue("@Actual_Leave_Date", DateTime.Today);
            cmd.Parameters.AddWithValue("@Rate", RateBox.SelectedItem);
            cmd.ExecuteNonQuery();
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            var bip = dataGridView1.CurrentRow.Cells[6].Value;
            DateTime date2 = new DateTime();
            date2 = Convert.ToDateTime(bip);
            TimeSpan days = new TimeSpan();
            days = date2.Subtract(date1);
            int days1 = days.Days;
            float total = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value) + Convert.ToInt32(TaxBox.Text);
            if (days1 == 0)
            {
                MessageBox.Show("Total price for living is " + total);
            }
            else if(days1 > 0)
            {
                total = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value) - 
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[17].Value) * days1;
                MessageBox.Show("Total price for living is " + total);
            }
            string s = dataGridView1.CurrentCell.Value.ToString();
            //  int selected_rows = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            string command = "DELETE FROM Visitors WHERE (Id=" + Convert.ToInt32(s) + ");";
            cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            string com = "DELETE FROM NotRooms WHERE (Id=" + Convert.ToInt32(s) + ");";
            cmd = new SqlCommand(com, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
