using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Spital
{
    public partial class FrmActualizarePacienti : Form
    {
        public FrmActualizarePacienti()
        {
            InitializeComponent();
            BindData();          
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgPacienti.Columns.Add(btn);
             btn.HeaderText = "Buton";
             btn.Text = "Delete";
             btn.Name = "Delete";
             btn.UseColumnTextForButtonValue = true;

        }
        public void BindData()
        {
            Global.con = new SqlConnection(Global.strConectare);
            Global.con.Open();
            string strCmdCnp = "select CNP from tPacienti";
            SqlDataAdapter daCnp = new SqlDataAdapter(strCmdCnp, Global.con);
            DataSet ds = new DataSet();
            daCnp.Fill(ds);
            cbCNP.DataSource = ds.Tables[0];
            cbCNP.ValueMember = "CNP";          
            this.cbCNP.SelectedIndex = -1;        
            Global.con.Close();
        }
   
        private void cbCNP_SelectedIndexChanged(object sender, EventArgs e)
        {

             DataView dv;
              DataTable dt = Global.ds.Tables["Pacienti"];
             dv = new DataView(dt, "CNP = '" + cbCNP.Text + "'", "codPacient asc", DataViewRowState.CurrentRows);
            dgPacienti.Visible = true;
             dgPacienti.DataSource = dv;          
            dgPacienti.Rows[0].Cells["codBoala"].Style.BackColor = Color.Turquoise;
            dgPacienti.Rows[0].Cells["codMedic"].Style.BackColor = Color.Turquoise;
            dgPacienti.Rows[0].Cells["greutate"].Style.BackColor = Color.Turquoise; 
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
          
            string cod = null;
            DialogResult result1 = MessageBox.Show("DATE CONFIDENTIALE !!! Sunteti autorizat sa modificati?", "Important Question",
      MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                cod = Interaction.InputBox("Introduceti codul de securitate");
                if (cod == "1234")
                {
                    SqlCommandBuilder cb = new SqlCommandBuilder(Global.daDetalii);
                    DataTable dtChange = Global.ds.Tables["Detalii"].GetChanges();

                    if (dtChange != null)
                    {
                        Global.daDetalii.Update(dtChange);
                        Global.ds.Tables["Detalii"].AcceptChanges();
                        dgvDateContact.Rows[0].Cells["numeContact"].Style.BackColor = Color.Turquoise;
                        dgvDateContact.Rows[0].Cells["nrContact"].Style.BackColor = Color.Turquoise;
                        dgvDateContact.Rows[0].Cells["adresa"].Style.BackColor = Color.Turquoise;
                        dgvDateContact.Rows[0].Cells["localitate"].Style.BackColor = Color.Turquoise;
                        MessageBox.Show("Comanda Efectuala!");
                    }

                        DataTable dt = Global.ds.Tables["Pacienti"].GetChanges();
                        if (dt != null)
                        {
                            Global.daPacienti.Update(dt);                      
                            Global.ds.Tables["Pacienti"].AcceptChanges();
                            data();
                     
                        MessageBox.Show("Comanda Efectuala!");

                        }
                    }
                else MessageBox.Show("Cod gresit!Nu aveti acces!");
            }
        }
        public void data()
        {  DataSet ds=new DataSet();
            SqlDataAdapter da=null;
            string sel = "select A.CNP,codPacient,nume+'  '+prenume as [Nume Pacient],B.codBoala,numeBoala,C.codMedic,numeMedic+'  '+prenumeMedic as [Nume Medic],durataInternare,dataNasterii,greutate,specializare,durataInternare*pret as [Total Plata] " +
                        "from tPacienti as A inner join tBoli as B on A.codBoala = B.codBoala " +
                        " inner join tMedici as C on A.codMedic=C.codMedic  inner join tBonuri as D on D.cnp=A.cnp " +
                            "where A.cnp=" + cbCNP.Text.ToString();
            da = new SqlDataAdapter(sel, Global.con);
            da.Fill(ds, "Nou");
            dgPacienti.DataSource = ds;
            dgPacienti.DataMember = "Nou";
            dgPacienti.Rows[0].Cells["codBoala"].Style.BackColor = Color.Turquoise;
            dgPacienti.Rows[0].Cells["codMedic"].Style.BackColor = Color.Turquoise;
            dgPacienti.Rows[0].Cells["greutate"].Style.BackColor = Color.Turquoise;
        }
        private void btnDateContact_Click(object sender, EventArgs e)
        {
            dgvDateContact.Visible = true;
            string str;        
            str = dgPacienti.Rows[dgPacienti.CurrentCell.RowIndex].Cells["codPacient"].Value.ToString();
            DataView dv;
            DataTable dt = Global.ds.Tables["Detalii"];
            dv = new DataView(dt, "codPacient = '" + str + "'", "codPacient asc", DataViewRowState.CurrentRows);           
            dgvDateContact.DataSource = dv;
            dgvDateContact.Rows[0].Cells["numeContact"].Style.BackColor = Color.Turquoise;
            dgvDateContact.Rows[0].Cells["nrContact"].Style.BackColor = Color.Turquoise;
            dgvDateContact.Rows[0].Cells["adresa"].Style.BackColor = Color.Turquoise;
            dgvDateContact.Rows[0].Cells["localitate"].Style.BackColor = Color.Turquoise;
        }

        private void btnAnulareMod_Click(object sender, EventArgs e)
        {
            Global.ds.Tables["Pacienti"].RejectChanges();
            Global.ds.Tables["Detalii"].RejectChanges();
        }

        private void dgPacienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string cod = null;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
               
                try
                {
                    using (Global.con = new SqlConnection(Global.strConectare))
                    {
                        DialogResult result1 = MessageBox.Show("Sunteti sigur ca doriti sa stergeti pacientul?", "Important Question",
        MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            cod = Interaction.InputBox("Introduceti codul de securitate");
                            if (cod == "1234")
                            {
                                Global.con.Open();
                                string delete = "delete tBonuri where cnp=@oldCnp";
                                SqlCommand cmd1 = new SqlCommand(delete, Global.con);
                                cmd1.Parameters.AddWithValue("@oldCnp", dgPacienti.Rows[0].Cells["cnp"].Value.ToString());
                                cmd1.ExecuteNonQuery();
                                string del = "delete tPacienti where cnp=@oldCnp";
                                SqlCommand cmd = new SqlCommand(del, Global.con);
                                cmd.Parameters.AddWithValue("@oldCnp", dgPacienti.Rows[0].Cells["cnp"].Value.ToString());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Pacient sters!");
                                data();
                            }
                            else MessageBox.Show("Cod gresit!Nu aveti acces!");
                        }
                    }
                      
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void btnAdPacienti_Click(object sender, EventArgs e)
        {
            FrmAdaugarePacienti f = new FrmAdaugarePacienti();
            f.Text = "Adauga Pacienti";
            f.ShowDialog();
        }
    }
}
