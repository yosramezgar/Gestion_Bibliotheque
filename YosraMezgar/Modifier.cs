using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YosraMezgar
{
    public partial class Modifier : Form
    {
        public Modifier()
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
                //MessageBox.Show("***Modification terminer avec succée***");
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception Générée :" + ex.Message);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            string txtsql = "update bib set titre_livre = '" + TxT_titre.Text +
                "', auteur = '" + TxT_AUTEUR.Text +
                "', annee_sortie = " + TxT_annee_sorti.Text +
                ", type_livre = '" + List_type_LIVRE.Text +
                "', editeur ='" + TxT_EDITEUR.Text +
                "' where isbn = " + TxT_ISBN.Text;
            LancerRequete(txtsql);
            MessageBox.Show("modification terminer");
            Close();
        }
    }
}
