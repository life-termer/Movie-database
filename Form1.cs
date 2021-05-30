using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Movie_database
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            string sql = "SELECT * FROM movies;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "movies");
            conn.Close();

            dgMovies.DataSource = ds;
            dgMovies.DataMember = "movies";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();

            string sql = "INSERT INTO movies (title, director, year, genre, rating, description)  VALUES (@title, @director, @year, @genre, @rating, @description) ";
            SQLiteParameter param1 = new SQLiteParameter();
            param1.ParameterName = "@title";
            param1.Value = txtTitle.Text;

            SQLiteParameter param2 = new SQLiteParameter();
            param2.ParameterName = "@director";
            param2.Value = txtDirector.Text;

            SQLiteParameter param3 = new SQLiteParameter();
            param3.ParameterName = "@year";
            param3.Value = numericUpDownYear.Value;

            SQLiteParameter param4 = new SQLiteParameter();
            param4.ParameterName = "@genre";
            param4.Value = comboBoxGenre.Text;

            SQLiteParameter param5 = new SQLiteParameter();
            param5.ParameterName = "@rating";
            param5.Value = numericUpDownRating.Value;

            SQLiteParameter param6 = new SQLiteParameter();
            param6.ParameterName = "@description";
            param6.Value = txtDesc.Text;

            SQLiteCommand comm = conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);
            comm.Parameters.Add(param4);
            comm.Parameters.Add(param5);
            comm.Parameters.Add(param6);
            comm.ExecuteNonQuery();
            conn.Close();

            txtTitle.Text = "";
            txtDirector.Text = "";
            txtDesc.Text = "";
            comboBoxGenre.Text = "";
            MessageBox.Show("Movie was added!");
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
                btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
        }
        private void dgMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChange.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                txtEditTitle.Text = dgMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEditDirector.Text = dgMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericUpDownEditYear.Text = dgMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxEditGenre.Text = dgMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                numericUpDownEditRating.Text = dgMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtEditDesc.Text = dgMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                lblIdValue.Text = dgMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
            catch (Exception ex) { }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();

            string sql = "DELETE FROM movies WHERE ID=" + lblIdValue.Text;
            SQLiteCommand comm = conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            conn.Close();

            txtEditTitle.Text = "";
            txtEditDirector.Text = "";
            txtEditDesc.Text = "";
            comboBoxEditGenre.Text = "";
            btnShowAll_Click(sender, e);
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();

            string sql = "UPDATE movies SET title=@title, director=@director, year=@year, genre=@genre, rating=@rating, description=@description WHERE ID=" + lblIdValue.Text;
            SQLiteParameter param1 = new SQLiteParameter();
            param1.ParameterName = "@title";
            param1.Value = txtEditTitle.Text;

            SQLiteParameter param2 = new SQLiteParameter();
            param2.ParameterName = "@director";
            param2.Value = txtEditDirector.Text;

            SQLiteParameter param3 = new SQLiteParameter();
            param3.ParameterName = "@year";
            param3.Value = numericUpDownEditYear.Value;

            SQLiteParameter param4 = new SQLiteParameter();
            param4.ParameterName = "@genre";
            param4.Value = comboBoxEditGenre.Text;

            SQLiteParameter param5 = new SQLiteParameter();
            param5.ParameterName = "@rating";
            param5.Value = numericUpDownEditRating.Value;

            SQLiteParameter param6 = new SQLiteParameter();
            param6.ParameterName = "@description";
            param6.Value = txtEditDesc.Text;

            SQLiteCommand comm = conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);
            comm.Parameters.Add(param4);
            comm.Parameters.Add(param5);
            comm.Parameters.Add(param6);
            comm.ExecuteNonQuery();
            conn.Close();

            btnShowAll_Click(sender, e);
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            string sql = "SELECT * FROM movies;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "movies");
            conn.Close();

            DataView dv;
            string filter = " title='" + txtSearchTitle.Text + "'";
            //dv = new DataView(ds.Tables[0], "naslov='Mala barka 6'", "", DataViewRowState.CurrentRows);
            dv = new DataView(ds.Tables[0], filter, "", DataViewRowState.CurrentRows);
            dgMovies.DataSource = dv;
        }

        private void btnSearchDirecror_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            string sql = "SELECT * FROM movies;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "movies");
            conn.Close();

            DataView dv;
            string filter = " director='" + txtSearchDirector.Text + "'";
            //dv = new DataView(ds.Tables[0], "naslov='Mala barka 6'", "", DataViewRowState.CurrentRows);
            dv = new DataView(ds.Tables[0], filter, "", DataViewRowState.CurrentRows);
            dgMovies.DataSource = dv;
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            string sql = "SELECT * FROM movies;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "movies");
            conn.Close();

            DataView dv;
            string filter = " genre='" + comboBoxSearchGenre.Text + "'";
            //dv = new DataView(ds.Tables[0], "naslov='Mala barka 6'", "", DataViewRowState.CurrentRows);
            dv = new DataView(ds.Tables[0], filter, "", DataViewRowState.CurrentRows);
            dgMovies.DataSource = dv;
        }

        private void btnSearchYear_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=movies.db;Version=3;UseUTF16Encoding=True;";
            string sql = "SELECT * FROM movies;";
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "movies");
            conn.Close();

            DataView dv;
            string filter = " year='" + numericUpDownSearchYear.Text + "'";
            //dv = new DataView(ds.Tables[0], "naslov='Mala barka 6'", "", DataViewRowState.CurrentRows);
            dv = new DataView(ds.Tables[0], filter, "", DataViewRowState.CurrentRows);
            dgMovies.DataSource = dv;
        }
    }
}
