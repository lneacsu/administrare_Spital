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
    public partial class FrmAdaugarePacienti : Form
    {
        public FrmAdaugarePacienti()
        {
            InitializeComponent();
            BindData();
            ListView();
            
        }
        public void ListView()
        {
            lvPacientiNoi.View = View.Details;
            lvPacientiNoi.Columns.Add("CNP", 120);
            lvPacientiNoi.Columns.Add("Cod Pacient", 80);
            lvPacientiNoi.Columns.Add("Nume", 100);
            lvPacientiNoi.Columns.Add("Prenume", 100);
            lvPacientiNoi.Columns.Add("Data Internare", 150);
            lvPacientiNoi.Columns.Add("Greutate", 60);
            lvPacientiNoi.Columns.Add("Cod Boala", 80);
            lvPacientiNoi.Columns.Add("Cod Medic", 80);
            lvPacientiNoi.Columns.Add("Localitate", 95);
            lvPacientiNoi.Columns.Add("Adresa", 125);
            lvPacientiNoi.Columns.Add("Contact Familie", 85);
            lvPacientiNoi.Columns.Add("Nr. Contact ", 85);
            string sql = "Select cnp,B.codPacient,nume,prenume,dataInternare,greutate,"+
                "codBoala,codMedic,localitate,adresa,numeContact,nrContact from tPacienti as A inner join tDetalii as B on A.codPacient=B.codPacient order by codPacient";
            Global.con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, Global.con);
            DataTable dc = new DataTable();
            ad.Fill(dc);
            for (int i = 0; i < dc.Rows.Count; i++)
            {
                DataRow d = dc.Rows[i];
                ListViewItem list = new ListViewItem(d["cnp"].ToString());
                list.SubItems.Add(d["codPacient"].ToString());
                list.SubItems.Add(d["nume"].ToString());
                list.SubItems.Add(d["prenume"].ToString());
                list.SubItems.Add(d["dataInternare"].ToString());
                list.SubItems.Add(d["greutate"].ToString());
                list.SubItems.Add(d["codBoala"].ToString());
                list.SubItems.Add(d["codMedic"].ToString());
                list.SubItems.Add(d["localitate"].ToString());
                list.SubItems.Add(d["adresa"].ToString());
                list.SubItems.Add(d["numeContact"].ToString());
                list.SubItems.Add(d["nrContact"].ToString());

                lvPacientiNoi.Items.Add(list);


            }
            Global.con.Close();
        }

        public void BindData()
        {
            Global.con = new SqlConnection(Global.strConectare);
            Global.con.Open();
            string strCmdBoala= "select codBoala,numeBoala from tBoli";
            string strCmdMedic = "select codMedic from tMedici";
            SqlCommand cmdBoala = new SqlCommand(strCmdBoala, Global.con);
            SqlCommand cmdMedic = new SqlCommand(strCmdMedic, Global.con);
            SqlDataAdapter daBoala = new SqlDataAdapter(strCmdBoala, Global.con);
            SqlDataAdapter daMedic = new SqlDataAdapter(strCmdMedic, Global.con);
            DataSet ds = new DataSet();
            DataSet dc = new DataSet();
            daBoala.Fill(ds);
            daMedic.Fill(dc);
            comboBoala.DataSource = ds.Tables[0];
            comboMedic.DataSource = dc.Tables[0];
             comboBoala.ValueMember = "codBoala";
            comboBoala.Enabled = true;
            this.comboBoala.SelectedIndex = -1;
            
            comboMedic.ValueMember = "codMedic";
            comboMedic.Enabled = true;
            this.comboMedic.SelectedIndex = -1;
            cmdBoala.ExecuteNonQuery();
            cmdMedic.ExecuteNonQuery();
            Global.con.Close();
           
        }

        private void btnAdaugPacient_Click(object sender, EventArgs e)
        { string sex=null;
           Global.con = new SqlConnection(Global.strConectare);
            Global.con.Open();
            if (Global.con.State == System.Data.ConnectionState.Open)
            {
                if (checkM.Checked == true)
                {
                  sex = "M";
                }else  if (checkF.Checked == true) { sex = "F"; }

                string ab = "insert into tDetalii values(@codPacient,@Localitate,@Adresa,@NumePers,@NrPers)";
                SqlParameter p1 = new SqlParameter("@codPacient", textCodPac.Text);
                SqlParameter p2 = new SqlParameter("@Localitate", textlocalitate.Text);
                SqlParameter p3 = new SqlParameter("@Adresa", textAdresa.Text);
                SqlParameter p4 = new SqlParameter("@NumePers", textNumePers.Text);
                SqlParameter p5 = new SqlParameter("@NrPers", textNrPers.Text);
                string ins = "INSERT into tPacienti values(@cnp,@Nume,@Prenume,@Greutate,@codPacient ,@codBoala, @codMedic, @Internare, @sex)";


                SqlParameter v1 = new SqlParameter("@cnp", textCNP.Text);
                SqlParameter v2 = new SqlParameter("@Nume", textNUME.Text);
                SqlParameter v3 = new SqlParameter("@Prenume", textPREN.Text);
                SqlParameter v4 = new SqlParameter("@Greutate", textGreutate.Text);
                SqlParameter v5 = new SqlParameter("@codPacient", textCodPac.Text);
                SqlParameter v6 = new SqlParameter("@codBoala", comboBoala.Text);
                SqlParameter v7 = new SqlParameter("@codMedic", comboMedic.Text);
                SqlParameter v8 = new SqlParameter("@Internare", textINTERNARE.Text.ToString());
                SqlParameter v9 = new SqlParameter("@sex", sex);

                string strBon = "insert into tBonuri(CNP,codBoala) values(@cnp,@codBoala)";

                SqlParameter bon1 = new SqlParameter("@cnp", textCNP.Text);
                SqlParameter bon2 = new SqlParameter("@codBoala", comboBoala.Text);
                try
                {
                    if (textCNP.Text.Length > 0)
                    {                      
                            SqlCommand cmd2 = new SqlCommand(ab, Global.con);
                            cmd2.Parameters.Add(p1);
                            cmd2.Parameters.Add(p2);
                            cmd2.Parameters.Add(p3);
                            cmd2.Parameters.Add(p4);
                            cmd2.Parameters.Add(p5);
                            cmd2.ExecuteNonQuery();
                            SqlCommand cmd1 = new SqlCommand(ins, Global.con);
                            cmd1.Parameters.AddRange(new SqlParameter[] { v1, v2, v3, v4, v5, v6, v7, v8, v9 });
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd3 = new SqlCommand(strBon, Global.con);
                            cmd3.Parameters.AddRange(new SqlParameter[] { bon1, bon2 });
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Comanda efectuata");
                            golire();
                            Global.con.Close();
                    }
                        else  throw new  Exception();
                }               
                catch (Exception)
                {
                    MessageBox.Show("Introduceti CNP");                   
                }
             
            }
        }
        public void golire()
        {
            textCodPac.Text = null;
            textAdresa.Text = null;
            textNumePers.Text = null;
            textNrPers.Text = null;
            textCNP.Text = null;
            textNUME.Text = null;
            textPREN.Text = null;
            textGreutate.Text = null;
            checkM.Checked = false;
            checkF.Checked = false;
            comboBoala.SelectedItem = null;
            comboMedic.SelectedItem = null;
            textINTERNARE.Text = null;


        }

        private void textINTERNARE_Enter(object sender, EventArgs e)
        {
            if (textINTERNARE.Text == "yyyy-mm-dd")
            {
                textINTERNARE.Text ="";
                textINTERNARE.ForeColor = Color.Black;
            }
        }

        private void textCodPac_Enter(object sender, EventArgs e)
        {
            if (textCodPac.Text == "P*")
            {
                textCodPac.Text = "";
                textCodPac.ForeColor = Color.Black;
            }
        }

        private void textCodPac_Leave(object sender, EventArgs e)
        {
            if (textCodPac.Text == "")
            {
                textCodPac.Text = "P*";
                textCodPac.ForeColor = Color.DarkGray;
            }
        }

        private void textINTERNARE_Leave(object sender, EventArgs e)
        {
            if (textINTERNARE.Text == "")
            {
                textINTERNARE.Text = "yyyy-mm-dd";
                textINTERNARE.ForeColor = Color.DarkGray;
            }
            
        }
       

        private void textGreutate_Enter_1(object sender, EventArgs e)
        {
            if (textGreutate.Text == "kg")
            {
                textGreutate.Text = "";
                textGreutate.ForeColor = Color.Black;
            }
        }

        private void textGreutate_Leave_1(object sender, EventArgs e)
        {
            if (textGreutate.Text == "")
            {
                textGreutate.Text = "kg";
                textGreutate.ForeColor = Color.DarkGray;
            }
        }
    }
}
