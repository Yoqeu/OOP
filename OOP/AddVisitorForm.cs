using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Linq;

namespace OOP
{
    public partial class AddVisitorForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public AddVisitorForm()
        {
            InitializeComponent();
            AddVisitorForm.ActiveForm.Load += AddVisitorForm_Load;
            DataGridView dataGridView = new DataGridView();
            for (int i = 0; i < 2; i++) //сколько столбцов нам нужно
            {
                //Добавление столбца - тип TextBox
                DataGridViewColumn column0 = new DataGridViewColumn();
                column0.Width = 90;

                if (i == 0)
                    column0.CellTemplate = new DataGridViewButtonCell();//Добавление столбца - тип кнопка, чтобы красиво было, ну как ты хочешь)
                else
                    column0.CellTemplate = new DataGridViewTextBoxCell();//Добавление столбца - тип TextBox

                dataGridView.Columns.Add(column0);
                column0.ReadOnly = true;
            }
            
        }

        private void AddVisitorForm_Load(object sender, EventArgs e)
        {
              
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NameBox_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            
        }
        private void SecNameBox_Enter(object sender, EventArgs e)
        {
           
        }
        private void PatronymicBox_Enter(object sender, EventArgs e)
        {
            
        }
        private void CommentBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameBox_Cue(object sender, EventArgs e)
        {

        }
        private void ComfortBox_Index(object sender, EventArgs e)
        {
            
        }
        private void ComfortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddVisitor_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            DateTime date2 = new DateTime();
            date2 = dateTimePicker1.Value;
            TimeSpan days = new TimeSpan();
            days = date2.Subtract(date1);
            int days1 = days.Days;
            int sum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) * days1;
            if (BarBox.Checked)
            {
                sum += days1 * 20;
            }
            if (CleaningBox.Checked)
            {
                sum += days1 * 10;
            }
            if (FoodServiceBox.Checked)
            {
                sum += days1 * 30;
            }
            if (JacuzziBox.Checked)
            {
                sum += days1 * 5;
            }
            if (AllIncludeBox.Checked)
            {
                sum += days1 * 50;
            }
            if (VIPBox.Checked)
            {
                sum += days1 * 100;
            }
            //TotalBox.Text = sum.ToString();
            int Num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            con = new SqlConnection(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            //DataContext db = new DataContext(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Visitors (Id, First_Name, Second_Name, Patronymic, Comment," +
                " Room_Number, Enter_Date, Leave_Date, Total_Price, Bar, Cleaning, Food_Service," +
                " Jacuzzi, All_Include, VIP, Comfort, Capacity, Price, Expense)" +
                " VALUES (@Id, @First_Name, @Second_Name, @Patronymic, @Comment, @Room_Number, " +
                "@Enter_Date, @Leave_Date, @Total_Price, @Bar, @Cleaning, @Food_Service, @Jacuzzi, " +
                "@All_Include, @VIP, @Comfort, @Capacity, @Price, @Expense)", con);
            cmd.Parameters.AddWithValue("@Id", IdBox.Text);
            cmd.Parameters.AddWithValue("@First_Name", NameBox.Text);
            cmd.Parameters.AddWithValue("@Second_Name", SecNameBox.Text);
            cmd.Parameters.AddWithValue("@Patronymic", PatronymicBox.Text);
            cmd.Parameters.AddWithValue("@Comment", CommentBox.Text);
            cmd.Parameters.AddWithValue("@Room_Number", Num);
            cmd.Parameters.AddWithValue("@Enter_Date", DateTime.Today);
            cmd.Parameters.AddWithValue("@Leave_Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Total_Price", sum);
            cmd.Parameters.AddWithValue("@Bar", BarBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@Cleaning", CleaningBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@Food_Service", FoodServiceBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@Jacuzzi", JacuzziBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@All_Include", AllIncludeBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@VIP", VIPBox.Checked.ToString());
            cmd.Parameters.AddWithValue("@Comfort", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Capacity", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@Price", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            cmd.Parameters.AddWithValue("@Expense", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO NotRooms (Id, Comfort, Capacity, Price, Number, First_Name," +
                " Second_Name, Release_Date, Expense) VALUES (@Id, @Comfort, @Capacity, @Price, @Number, " +
                "@First_Name, @Second_Name, @Release_Date, @Expense)", con);
            cmd.Parameters.AddWithValue("@Id", IdBox.Text);
            cmd.Parameters.AddWithValue("@Comfort", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Capacity", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@Price", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            cmd.Parameters.AddWithValue("@Number", Num);
            cmd.Parameters.AddWithValue("@First_Name", NameBox.Text);
            cmd.Parameters.AddWithValue("@Second_Name", SecNameBox.Text);
            cmd.Parameters.AddWithValue("@Release_Date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Expense", dataGridView1.CurrentRow.Cells[5].Value);
            cmd.ExecuteNonQuery();
            string s = dataGridView1.CurrentCell.Value.ToString();
            //int selected_rows = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            string command = "DELETE FROM Rooms WHERE (Id=" + Convert.ToInt32(s) + ");";
            cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            roomsTableAdapter.Fill(yoqesDataSet4.Rooms);
            dataGridView1.Refresh();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComfortBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddVisitorForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet4.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet4.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet3.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet3.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet2.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet2.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet1.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet1.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yoqesDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqesDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.yoqeDataSet.Rooms);
            yoqeDataSet.EnforceConstraints = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Visitors". При необходимости она может быть перемещена или удалена.
            this.visitorsTableAdapter.Fill(this.yoqeDataSet.Visitors);

        }

        private void NumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TotalBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            DateTime date2 = new DateTime();
            date2 = dateTimePicker1.Value;
            TimeSpan days = new TimeSpan();
            days = date2.Subtract(date1);
            int days1 = days.Days;
            int sum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value) * days1;
            if(BarBox.Checked)
            {
                sum += days1 * 20;
            }
            if(CleaningBox.Checked)
            {
                sum += days1 * 10;
            }
            if(FoodServiceBox.Checked)
            {
                sum += days1 * 30;
            }
            if(JacuzziBox.Checked)
            {
                sum += days1 * 5;
            }
            if(AllIncludeBox.Checked)
            {
                sum += days1 * 50;
            }
            if(VIPBox.Checked)
            {
                sum += days1 * 100;
            }
            TotalBox.Text = sum.ToString();
        }

        private void AllIncludeBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AllIncludeBox.Checked)
            {
                BarBox.Checked = false;
                BarBox.Enabled = false;
            }
            else
            {
                BarBox.Enabled = true;
            }
            if (AllIncludeBox.Checked)
            {
                CleaningBox.Checked = false;
                CleaningBox.Enabled = false;
            }
            else
            {
                CleaningBox.Enabled = true;
            }
            if (AllIncludeBox.Checked)
            {
                FoodServiceBox.Checked = false;
                FoodServiceBox.Enabled = false;
            }
            else
            {
                FoodServiceBox.Enabled = true;
            }
            if (AllIncludeBox.Checked)
            {
                JacuzziBox.Checked = false;
                JacuzziBox.Enabled = false;
            }
            else
            {
                JacuzziBox.Enabled = true;
            }

        }

        private void VIPBox_CheckedChanged(object sender, EventArgs e)
        {
            if(VIPBox.Checked)
            {
                
                    AllIncludeBox.Checked = false;
                    AllIncludeBox.Enabled = false;
                    BarBox.Checked = false;
                    BarBox.Enabled = false;
                    CleaningBox.Checked = false;
                    CleaningBox.Enabled = false;
                    FoodServiceBox.Checked = false;
                    FoodServiceBox.Enabled = false;
                    JacuzziBox.Checked = false;
                    JacuzziBox.Enabled = false;
                    
                
            }
            else
            {
                BarBox.Enabled = true;
                CleaningBox.Enabled = true;
                FoodServiceBox.Enabled = true;
                JacuzziBox.Enabled = true;
                AllIncludeBox.Enabled = true;
            }
        }
    }
}
