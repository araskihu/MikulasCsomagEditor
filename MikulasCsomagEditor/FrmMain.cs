using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmMain : Form
    {
        static string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\Resources\mikulas.mdf;Trusted_Connection=True;";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            FrmOsztaly frmOsztaly = new FrmOsztaly(connectionString);
            frmOsztaly.Show();
        }

        private void lotteryBtn_Click(object sender, EventArgs e)
        {
            FrmSorsolas frmSorsolas = new FrmSorsolas(connectionString);
            frmSorsolas.Show();
        }

        private void builderBtn_Click(object sender, EventArgs e)
        {
            FrmCsomagEpito frmCsomagEpito = new FrmCsomagEpito(connectionString);
            frmCsomagEpito.Show();
        }
    }
}
