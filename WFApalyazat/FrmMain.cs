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

namespace WFApalyazat
{
    public partial class FrmMain : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=palyazatok;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) => UpdateDGV();

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            var connection = new SqlConnection(connectionString);
            connection.Open();

            var command = new SqlCommand("SELECT palyazat.id, tervezetA + tervezetC, COUNT(palyazatId), SUM(ertek) FROM palyazat " +
                "INNER JOIN szamla ON palyazat.id = palyazatId " +
                "GROUP BY palyazat.id, tervezetA + tervezetC " +
                "ORDER BY id;", connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvMain.Rows.Add(
                    reader[0],
                    String.Format("{0:N0}", reader[1]) + " Ft",
                    reader[2] + " db",
                    String.Format("{0:N0}", reader[3]) + " Ft");
            }

            reader.Close();

            connection.Close();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUjPalyazat_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjPalyazat(connectionString);
            frm.ShowDialog();
            UpdateDGV();
        }
    }
}
