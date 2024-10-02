using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YosraMezgar
{
    public partial class login : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = livre.mdb";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtsql = "select count (login) from login where login='" +
                textBox1.Text + "' and pwd='" + textBox2.Text + "'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            Int32 ival;
            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifiant", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    Form1 frm2 = new Form1();
                    frm2.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
