using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YosraMezgar
{
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        

        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = livre.mdb";
        public void LancerRequete(string requete)
        {
            // connection avec base 
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                // ouvrir cnx
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***insertion terminer avec succée***");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception Générée :" + ex.Message);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            String txtinsert;
            txtinsert = "insert into bib values(" +
                "'" + TxT_isbn.Text +
                "','" + TxT_titre_livre.Text +
                "','" + TxT_auteur.Text +
                "','" + TxT_annee_sortie.Text +
                "','" + List_type_livre.Text +
                "','" + TxT_editeur.Text +
                "')";
            LancerRequete(txtinsert);
        }


        private void Ajout_Load(object sender, EventArgs e)
        {
            Int32 count = 0;
            string txtsql;
            txtsql = "select max (isbn) from bib";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            count = Convert.ToInt32(ocm.ExecuteScalar());
            ocn.Close();
            count++;
            TxT_isbn.Text = count.ToString();
            


        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
