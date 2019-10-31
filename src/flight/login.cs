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

namespace db_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Label l1 = new Label();
            
            //chackStatus();
            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\com pra\pf lab\db project\db project\Database1.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string user1 = userName_textBox.Text.ToString();
            string pass1 = password_textBox.Text.ToString();
            string query = "select * from login where id='"+user1+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
        //    SqlDataAdapter da = DB.ExecuteQury(query);//new SqlDataAdapter(query, con);
        
          //   DataSet ds=new DataSet();
         //   da.Fill(ds);
            if(dr.Read())
            {
                if (pass1 == dr["password"].ToString())
                {
                    //MessageBox.Show("loged in");
                    HomePage f2 = new HomePage();
                    this.Close();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("wrong password");
                }
            }
            else
            {
                MessageBox.Show("invalid username");
            }
        }

        private void chackStatus()
        {


            if (userName_textBox.Text == "")
            {

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
