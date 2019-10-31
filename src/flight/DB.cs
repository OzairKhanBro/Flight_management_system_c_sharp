using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_project
{
    static class DB
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;

       // private static SqlConnection connection { get; set; }

        private static void open()
        {
            string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\com pra\pf lab\db project\db project\Database1.mdf; Integrated Security = True";
            connection = new SqlConnection(conString);
            connection.Open();
        }
        private static void close()
        {
            connection.Close();
        }
        public static SqlDataReader getDataReader(String SqlQuery)
        {
            open();
            command = new SqlCommand(SqlQuery,connection);
            close();

            return command.ExecuteReader();
        }
        public static SqlDataAdapter getDataAdapter(String SqlQuery)
        {
            open();
            // string query = "select * from login where id='" + user1 + "'";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            dataAdapter= new SqlDataAdapter(SqlQuery,connection);
            close();
            return dataAdapter;
        //    if (dr.Read())
        //    {
        //        if (pass1 == dr["password"].ToString())
        //        {
        //            MessageBox.Show("loged in");
        //            HomePage f2 = new HomePage();
        //            this.Hide();
        //            f2.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("wrong password");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("invalid username");
        //    }
        //}

        //private void chackStatus()
        //{


        //    if (userName_textBox.Text == "")
        //    {

        //    }
        //}

    }
}
}
