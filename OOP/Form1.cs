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
using OOP;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*string sql = "Select From_Date From ReservedRooms";
            string sqlConnection = @"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True";
            SqlConnection con = new SqlConnection(sqlConnection);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string command = "DELETE FROM Rooms WHERE (Id=" + Convert.ToInt32(s) + ");";
            cmd = new SqlCommand(command, con);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                    {
                        DateTime date1 = new DateTime();
                        date1 = DateTime.Today;
                        DateTime date2 = new DateTime();
                        date2 = cell;
                    }
                }
                    
            }*/

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Info_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVisitor_Click(object sender, EventArgs e)
        {
            AddVisitorForm addVisitorForm = new AddVisitorForm();
            this.Hide();
            addVisitorForm.Enabled = true;
            addVisitorForm.ShowDialog();
            this.Show();
            Close();
        }

        private void cueTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_Button_Click(object sender, EventArgs e)
        {
            RoomInfoForm roomInfoForm= new RoomInfoForm();
            this.Hide();
            roomInfoForm.Enabled = true;
            roomInfoForm.ShowDialog();
            this.Show();
            Close();
        }

        private void Delete_Visitor_Click(object sender, EventArgs e)
        {
            DeleteVisitorsForm deleteVisitorsForm = new DeleteVisitorsForm();
            this.Hide();
            deleteVisitorsForm.Enabled = true;
            deleteVisitorsForm.ShowDialog();
            this.Show();
            Close();
        }

        private void ReserveRoom_Click(object sender, EventArgs e)
        {
            ReservedForm reservedForm = new ReservedForm();
            this.Hide();
            reservedForm.Enabled = true;
            reservedForm.ShowDialog();
            this.Show();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }

