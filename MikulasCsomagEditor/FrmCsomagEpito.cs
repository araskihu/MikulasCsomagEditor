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
    public partial class FrmCsomagEpito : Form
    {
        private Dictionary<string, int> Prices;
        private SqlConnection connection;
        private int overallPrice;
        public FrmCsomagEpito(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
            Prices = new Dictionary<string, int>();
            overallPrice = 0;
        }

        private void FrmCsomagEpito_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM belevalok", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                itemCB.Items.Add(reader["nev"].ToString());
                Prices.Add(reader["nev"].ToString(), Convert.ToInt32(reader["egysegar"]));
            }
            connection.Close();
            itemCB.SelectedIndex = 0;
            pirceLBL.Text = "0 Ft";
        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {
            if (idTB.Text != null || idTB.Text != String.Empty)
            {
                if (int.TryParse(idTB.Text, out int id))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT id FROM emberek WHERE id = @id", connection);
                    sqlCommand.Parameters.AddWithValue("id", id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        valueUD.Enabled = true;
                        itemCB.Enabled = true;
                        pieceTB.Enabled = true;
                        addBTN.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }
                    connection.Close();
                }
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string termekNev = itemCB.Text;
            if (int.TryParse(pieceTB.Text, out int darab))
            {
                packetDGV.Rows.Add(termekNev, darab);
                overallPrice += Prices[termekNev];
                pirceLBL.Text = (overallPrice * darab).ToString() + " Ft";

                if (overallPrice > valueUD.Value)
                {
                    MessageBox.Show("Meghalattad az érték határt!");
                }
            }
            else
            {
                MessageBox.Show("Csak számot adhatsz meg a darabnál!");
            }
        }
    }
}
