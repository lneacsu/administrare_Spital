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
using System.Threading;

namespace Spital
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            t.Abort();           
        }
        public void Splash()
        {
            Application.Run(new SplashScreen());
        }
        public void Load_Medici() {
            Global.listMedic = new List<Medic>();
            Global.con.Open();
            string strMedic = "select * from tMedici";
            SqlCommand cmd = new SqlCommand(strMedic, Global.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Medic medic = new Medic(dr["codMedic"].ToString(), dr["numeMedic"].ToString(), dr["prenumeMedic"].ToString(), dr["specializare"].ToString());


                Global.listMedic.Add(medic);
            }
            Global.con.Close();
        }
        public void Load_Boli()
        {
            Global.listBoala = new List<Boala>();
            Global.con.Open();
            string strMedic = "select * from tBoli";
            SqlCommand cmd = new SqlCommand(strMedic, Global.con);
            SqlDataReader dr = cmd.ExecuteReader();
            String nr;
            while (dr.Read())
            {
                if (dr["durataInternare"] is DBNull)
                    nr = null;
                else nr =dr["durataInternare"].ToString();

                Boala boala = new Boala(dr["codBoala"].ToString(), dr["numeBoala"].ToString(), nr);

                Global.listBoala.Add(boala);
            }
            Global.con.Close();
        }
        public void Load_Pac()
        {
            Global.listPac = new List<Pacient>();
            Global.con.Open();
            string strMedic = "select * from tPacienti";
            SqlCommand cmd = new SqlCommand(strMedic, Global.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pacient pac = new Pacient(dr["codPacient"].ToString(), dr["nume"].ToString(), dr["prenume"].ToString(),dr["cnp"].ToString(), (DateTime)dr["dataNasterii"]
                    , Convert.ToInt32(dr["greutate"]), null,null, (DateTime)dr["dataInternare"]);
                foreach (Boala b in Global.listBoala)
                {
                   if (b.codBoala.Equals(dr["codBoala"].ToString()))
                      pac.boala = new Boala(b.codBoala, b.numeBoala, b.durataInernare);
                }
                foreach (Medic medic in Global.listMedic){
                    if(medic.cod.Equals(dr["codMedic"].ToString()))
                        pac.medic =new Medic(medic.cod,medic.nume,medic.prenume,medic.departament);
                }

                Global.listPac.Add(pac);
            }
            Global.con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Global.con = new SqlConnection(Global.strConectare);
            Global.ds = new DataSet();
            //----------------------------------------------
            Load_Medici();
            Load_Boli();
            Load_Pac();

            //----------------------------------------------------

            string strSelect = "select * from tMedici";
            Global.daMedici = new SqlDataAdapter(strSelect, Global.con);

            Global.daPacienti = Global.ConfigurareAdapter_daPacienti(Global.con);
            Global.daPacienti.Fill(Global.ds, "Pacienti");

            string strDep = "select specializare, count(codPacient) as [Nr Pacienti] from tMedici as A " +
                "inner join tPacienti as B on A.codMedic = B.codMedic " +
                "group by specializare ";
            Global.daDepartamente = new SqlDataAdapter(strDep, Global.con);

            string strContact = "select * from tDetalii";
            Global.daDetalii = new SqlDataAdapter(strContact, Global.con);

            Global.daXML = new SqlDataAdapter("Select * from tDocumenteXML", Global.con);

            Global.daBoli = new SqlDataAdapter("select * from tBoli", Global.con);

            Global.daBonuri = new SqlDataAdapter("select * from tBonuri", Global.con);

            Global.daMedici.Fill(Global.ds, "Medici");
            Global.daDepartamente.Fill(Global.ds, "Departamente");
            Global.daDetalii.Fill(Global.ds, "Detalii");
            Global.daBoli.Fill(Global.ds, "Boli");
            Global.daBonuri.Fill(Global.ds, "Bonuri");
            Global.daXML.Fill(Global.ds, "DocXML");
        }






     

        private void adaugarePacienti_Click(object sender, EventArgs e)
        {
            FrmAdaugarePacienti pacienti = new FrmAdaugarePacienti();
            pacienti.Text = "Pacienti";
            pacienti.ShowDialog();
        }

        private void adaugareBoli_Click(object sender, EventArgs e)
        {
            FrmAdaugareBoli boli = new FrmAdaugareBoli();
            boli.Text = "Boli";
            boli.ShowDialog();
        }

        private void vizualizareMedici_Click(object sender, EventArgs e)
        {
            FrmVizualizareMedici vizMedici = new FrmVizualizareMedici();
            vizMedici.Text = "Vizualizare Medici";
            vizMedici.ShowDialog();

        }

        private void actualizareMedici_Click(object sender, EventArgs e)
        {
            FrmActualizareMedici actMedici = new FrmActualizareMedici();
            actMedici.Text = "Actualizare Medici";
            actMedici.ShowDialog();

        }

        private void actualizareInformatiiPacienti_Click(object sender, EventArgs e)
        {
            FrmActualizarePacienti f = new FrmActualizarePacienti();
            f.Text = "Actualizare Informatii Pacienti";
            f.ShowDialog();
        }

        private void boliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamente f = new FrmDepartamente();
            f.Text = "Departamente";
            f.ShowDialog();
        }

      
        

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatistici f = new FrmStatistici();
            f.Text = "Alte Statistici";
            f.ShowDialog();
        }

     
    }
}
