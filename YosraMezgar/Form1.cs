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
    public partial class Form1 : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = livre.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void charger_Liste_livre()
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            txtsql = "select * from bib";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] {reader.GetValue(0).ToString(),
                reader.GetString(1).ToString(),
                reader.GetString(2).ToString(),
                reader.GetValue(3).ToString(),
                reader.GetString(4).ToString(),
                reader.GetString(5).ToString()};
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
            ocn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charger_Liste_livre();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Ajout fm = new Ajout();
            fm.ShowDialog();
        }

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

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Modifier frm_modif = new Modifier();
            int lignecourrant;
            string ISBN, Titre_de_livre, Auteur, Annee_de_sortie, Type_de_livre, Editeur;

            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            Titre_de_livre = dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString();
            Auteur = dataGridView1.Rows[lignecourrant].Cells[2].Value.ToString();
            Annee_de_sortie = dataGridView1.Rows[lignecourrant].Cells[3].Value.ToString();
            Type_de_livre = dataGridView1.Rows[lignecourrant].Cells[4].Value.ToString();
            Editeur = dataGridView1.Rows[lignecourrant].Cells[5].Value.ToString();

            frm_modif.TxT_ISBN.Text = ISBN;
            frm_modif.TxT_titre.Text = Titre_de_livre;
            frm_modif.TxT_AUTEUR.Text = Auteur;
            frm_modif.TxT_annee_sorti.Text = Annee_de_sortie;
            frm_modif.List_type_LIVRE.Text = Type_de_livre;
            frm_modif.TxT_EDITEUR.Text = Editeur;
            
            frm_modif.TxT_ISBN.Enabled = false;
            frm_modif.ShowDialog();
            charger_Liste_livre();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int lignecourrant;
            string ISBN;
            string req_sup;
            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;
            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            DialogResult Supp_client =
                (MessageBox.Show("voulez vous supprimer le livre '" + dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString() +
                "'", "suppression livre", MessageBoxButtons.YesNo));
            if (Supp_client == DialogResult.Yes)
            {
                req_sup = "delete from bib where ISBN=" + ISBN + "";
                LancerRequete(req_sup);
                charger_Liste_livre();
            }
            else
            {
                return;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            charger_Liste_livre();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            
            txtsql = "select *  from bib where  titre_livre like '%" + textBox1.Text + "%' or auteur  like '%" + textBox1.Text + "%'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(0).ToString(),
             reader.GetString(1),
                          reader.GetString(2),
                          reader.GetValue(3).ToString(),
                          reader.GetString(4),
                          reader.GetString(5) };
                dataGridView1.Rows.Add(row);

            }
            reader.Close();
            ocn.Close();
        }
    }
    }

