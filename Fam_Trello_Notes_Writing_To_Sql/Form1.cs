using MySqlX.XDevAPI.Relational;
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

            comm.Parameters.AddWithValue("@ID", Convert.ToInt16(inpt_id.Text));
            con.Open();
            SqlDataReader sr = comm.ExecuteReader();



            while (sr.Read())
            {
                MessageBox.Show(sr["ID"].ToString() + " " +sr["title"]);
            }
            con.Close();
        }

        private void btnGetNotes_Click(object sender, EventArgs e)
        {
            ds = new DataSet("NotesSP");
            comm = new SqlCommand("GetNotes", con);
            comm.CommandType = CommandType.StoredProcedure;
            //con.Open();
            //SqlDataReader sr = comm.ExecuteReader();
            //DataTable schemaTable = sr.GetSchemaTable();

            DataTable data = new DataTable("Notes");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];

            
            //int count = 0;
            //while (sr.Read())
            //{
            //    DataColumn column = new DataColumn();
            //    column.DataType = sr[count].GetType();
            //    column.ColumnName = sr.GetName(count);
            //    data.Columns.Add(column);
            //    count++;
            //}


            ////for (int i = 0; i < sr.FieldCount; i++)
            ////{
            ////    object co = sr.GetSqlValue(i);

            ////    sr.NextResult();
            ////}
            
            //sr.Close();
            //sr = comm.ExecuteReader();

            //while (sr.Read())
            //{
            //    DataRow dr = data.NewRow();
            //    dr["ID"] = sr["ID"];
            //    dr["title"] = sr["title"];
            //    dr["description"] = sr["description"];
            //    //dr["users_tagged"] = sr["users_tagged"];
            //    data.Rows.Add(dr);
            //}

            //dataGridView.DataSource = data;
            con.Close();
        }


        private void btnClearTable_Click(object sender, EventArgs e)
        {
            ds.Clear();
            dataGridView.DataSource = ds;
        }
    }
}
