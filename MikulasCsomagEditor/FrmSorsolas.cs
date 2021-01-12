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

namespace MikulasCsomagEditor
{
    public partial class FrmSorsolas : Form
    {
        private SqlConnection connection;
        public FrmSorsolas(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void FrmSorsolas_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT DISTINCT osztaly FROM emberek", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                classCB.Items.Add(reader["osztaly"].ToString());
            }

            connection.Close();
        }

        private void classCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(classCB.Text);
        }

        void LoadData(string classStr)
        {
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT id, nev FROM emberek WHERE osztaly = @osztaly", connection);
            sqlCommand.Parameters.AddWithValue("osztaly", classStr);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                osztalyDGV.Rows.Add(reader["id"], reader["nev"], reader["id"], reader["nev"]);
            }

            connection.Close();
        }
    }
}
