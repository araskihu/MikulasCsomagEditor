using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmOsztaly : Form
    {
        private SqlConnection connection;
        public FrmOsztaly(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void FrmOsztaly_Load(object sender, EventArgs e)
        {

        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            pathTb.Text = ofd.ShowDialog() == DialogResult.OK
                    ? ofd.FileName
                    : null;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(pathTb.Text);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO emberek (nev, osztaly) VALUES(@nev, @osztaly)", connection);
            sqlCommand.Parameters.Add("nev", SqlDbType.Text);
            sqlCommand.Parameters.Add("osztaly", SqlDbType.Text);

            while (!sr.EndOfStream)
            {
                sqlCommand.Parameters["osztaly"].Value = classTb.Text;
                sqlCommand.Parameters["nev"].Value = sr.ReadLine();
                sqlCommand.ExecuteNonQuery();
            }

            sqlCommand.Dispose();
            connection.Close();
            MessageBox.Show("A névsor hozzáadva!");
        }

        private void pathTb_TextChanged(object sender, EventArgs e)
        {
            addBtn.Enabled = true;
            classTb.Enabled = true;
        }
    }
}
