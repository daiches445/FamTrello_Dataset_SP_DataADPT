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

namespace Fam_Trello_Notes_Writing_To_Sql
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=LAPTOP-RO7AUIMF\SQLEXPRESS;Initial Catalog=FamTrellTest;Integrated Security=True";
        SqlConnection con = null;
        SqlCommand comm = null;
        SqlDataReader reader;
        SqlDataAdapter adpt;
        DataTable noteDataTbl;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            ds = new DataSet("Notes");
            comm = new SqlCommand(@"SELECT * FROM Notes", con);
            adpt = new SqlDataAdapter(comm.CommandText, con);

        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            DataRow dr = noteDataTbl.NewRow();

            dr["ID"] = inpt_id.Text;
            dr["title"] = inpt_title.Text;
            dr["description"] = inpt_desc.Text;
            dr["users_tagged"] = GetUserTagged();

            noteDataTbl.Rows.Add(dr);

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adpt.Fill(ds, "Notes");
            noteDataTbl = ds.Tables["Notes"];

            dataGridView.DataSource = noteDataTbl;

        }



        private void btn_delete_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in ds.Tables["Notes"].Rows)
            {
                if(row["ID"].ToString().TrimEnd() == inpt_id.Text)
                {
                    row.Delete();
                    break;
                }
                
                
            }

        }
        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in noteDataTbl.Rows)
            {
                if(row["ID"].ToString().TrimEnd() == inpt_id.Text)
                {
                    row["title"] = inpt_title.Text;
                    row["description"] = inpt_desc.Text;
                    row["users_tagged"] = GetUserTagged();
                }
            }

        }


        private string GetUserTagged()
        {
            string users_tagged_str = "";
            int counterItems = 0;
            foreach (var item in cbx_users.CheckedItems)
            {
                if (counterItems == 0)
                    users_tagged_str += item;
                else
                    users_tagged_str += ", " + item;
                counterItems++;
            }
            return users_tagged_str;
        }

        private void btnUpdtateSQL_Click(object sender, EventArgs e)
        {

            new SqlCommandBuilder(adpt);
            adpt.Update(noteDataTbl);
        }

        private void btnSPGetNoteID_Click(object sender, EventArgs e)
        {
            comm = new SqlCommand("GetNoteByID",con);
            comm.CommandType = CommandType.StoredProcedure;
            //SqlParameter par = new SqlParameter("@ID", SqlDbType.SmallInt) ;
            //par.Direction = ParameterDirection.Input;
            //par.Value = Convert.ToInt16(inpt_id.Text);
            comm.Parameters.AddWithValue("@ID", Convert.ToInt16(inpt_id.Text));
            con.Open();
            //comm.Parameters.Add(par);
            SqlDataReader sr = comm.ExecuteReader();
            
            while (sr.Read())
            {
                MessageBox.Show(sr["ID"].ToString() + " " +sr["title"]);
            }
            con.Close();
        }

        private void btnGetNotes_Click(object sender, EventArgs e)
        {
            comm = new SqlCommand("GetNotes", con);
            comm.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader sr = comm.ExecuteReader();

            DataTable data = new DataTable();
            
            while (sr.Read())
            {
                data.NewRow();
                data.Rows.Add(sr["ID"].ToString(),"dd","ss","ss");
            }
            dataGridView.DataSource = data;
            con.Close();
        }
    }
}
