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
    public partial class FrmUjPalyazat : Form
    {
        string connectionString;
        public FrmUjPalyazat(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void FrmUjPalyazat_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);

            connection.Open();
            var command = new SqlCommand("SELECT MAX(id) + 1 FROM palyazat;", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbID.Text = reader[0].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string aKat = tbAkategoria.Text;
            string cKat = tbCkategoria.Text;

            var connection = new SqlConnection(connectionString);

            try
            {
                string errMessage = "";

                int a, c;

                if (!int.TryParse(tbID.Text, out _)) errMessage += "Az 'A kategória értékkere' mezőbe csak szám érték kerülhet!\n";
                if (!int.TryParse(tbCkategoria.Text, out c)) errMessage += "A 'C kategória értékkere' mezőbe csak szám érték kerülhet!\n";
                if (!int.TryParse(tbAkategoria.Text, out a)) errMessage += "Az 'A kategória értékkere' mezőbe csak szám érték kerülhet!\n";
                if (a < 0) errMessage += "Az 'A kategória értékkerete' mezőbe csak pozitív szám kerülhet!\n";
                if (c < 0) errMessage += "A 'C kategória értékkerete' mezőbe csak pozitív szám kerülhet!\n";

                if (!String.IsNullOrEmpty(errMessage))
                {
                    throw new Exception(errMessage);
                }

                connection.Open();
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand($"INSERT INTO palyazat VALUES ('{id}','{aKat}','{cKat}');", connection),
                };
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Dispose();
        }
    }
}
