using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spital
{
    public partial class FrmAdaugareBoli : Form
    {
        public FrmAdaugareBoli()
        {
            InitializeComponent();
        }

        public void BlindData()
        {
            listViewBoli.View = View.Details;
            listViewBoli.Columns.Add("Cod Boala", 75);
            listViewBoli.Columns.Add("Denumire", 100);
            listViewBoli.Columns.Add("Durata Medie Internare", 100);
            foreach (Boala b in Global.listBoala) {
                ListViewItem list = new ListViewItem(b.codBoala);
                list.SubItems.Add(b.numeBoala);
                list.SubItems.Add(b.durataInernare);
                listViewBoli.Items.Add(list);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            BlindData();
        }

        private void btnAdaugareBoli_Click(object sender, EventArgs e)
        {
            string adaugare = "insert into tBoli values(@codBoala,@numeBoala,@durataInternare)";
            SqlParameter p1 = new SqlParameter("@codBoala", tbCodBoala.Text);
            SqlParameter p2 = new SqlParameter("@numeBoala", tbDenumire.Text);
            SqlParameter p3 = new SqlParameter("@durataInternare", tbDurataInternare.Text);
            try
            {
                Global.con.Open();
                SqlCommand cmd = new SqlCommand(adaugare, Global.con);
                cmd.Parameters.AddRange(new SqlParameter[] { p1, p2, p3 });
                cmd.ExecuteNonQuery();            
                Global.listBoala.Add(new Boala(tbCodBoala.Text, tbDenumire.Text, tbDurataInternare.Text));              
                MessageBox.Show("Comanda completa!");
                Global.con.Close();
                golire();
                
             
            }
            catch(Exception a) { MessageBox.Show(a.ToString()); }

        }

        public void golire() {
            tbCodBoala.Text = null;
            tbDenumire.Text = null;
            tbDurataInternare.Text = null;

        }
        private void btbRefresh_Click(object sender, EventArgs e)
        {
            listViewBoli.Items.Clear();
            listViewBoli.View = View.Details;
            foreach (Boala b in Global.listBoala)
            {
                ListViewItem list = new ListViewItem(b.codBoala);
                list.SubItems.Add(b.numeBoala);
                list.SubItems.Add(b.durataInernare);
                listViewBoli.Items.Add(list);
            }
        }

        private void tbCodBoala_Enter(object sender, EventArgs e)
        {
            if (tbCodBoala.Text == "B*")
            {
                tbCodBoala.Text = "";
                tbCodBoala.ForeColor = Color.Black;
            }
        }

        private void tbCodBoala_Leave(object sender, EventArgs e)
        {
            if (tbCodBoala.Text == "")
            {
                tbCodBoala.Text = "B*";
                tbCodBoala.ForeColor = Color.DarkGray;
            }
        }
    }
}
