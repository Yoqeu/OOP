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
    public partial class LoginPage : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            //DataContext db = new DataContext(@"Data Source=YOQES-PC;Initial Catalog=Yoqes;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select Count (*) From Users Where Login = " +
                "'" + LoginBox.Text + "' and Password = '" + PasswordBox.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Enabled = true;
                form1.ShowDialog();
                this.Show();
                Close();
            }
            else 
            {
                MessageBox.Show("Invalid login or password");
            }
        }
    }
}
