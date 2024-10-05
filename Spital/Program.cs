using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Spital
{ class Global
    {
        public static string strConectare = ConfigurationManager.AppSettings["stringConectare"];
        public static SqlConnection con = null;
        public static SqlDataAdapter daMedici;
        public static SqlDataAdapter daPacienti;
        public static SqlDataAdapter daDetalii;
        public static SqlDataAdapter daBoli;
        public static SqlDataAdapter daXML;
        public static SqlDataAdapter daBonuri;
        public static SqlDataAdapter daDepartamente;
        public static DataSet ds;
        public static List<Medic> listMedic;
        public static List<Pacient> listPac;
        public static List<Boala> listBoala;

        public static SqlDataAdapter ConfigurareAdapter_daPacienti(SqlConnection con) {

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            string strUpdate = "update tPacienti " +
                "set codBoala=@codBoala ,codMedic=@codMedic ,greutate=@greutate " +
                "where cnp=@oldCNP";
            cmd = new SqlCommand(strUpdate, con);
            SqlParameter update1 = new SqlParameter("@codBoala", SqlDbType.Char, 5, "codBoala");
            SqlParameter update2 = new SqlParameter("@codMedic", SqlDbType.Char, 3, "codMedic");
            SqlParameter update3 = new SqlParameter("@greutate", SqlDbType.Float, 3, "greutate");
            SqlParameter update4 = new SqlParameter("@oldCNP", SqlDbType.Char, 13, "cnp");
            update4.SourceVersion = DataRowVersion.Original;
            cmd.Parameters.AddRange(new SqlParameter[] { update1, update2, update3, update4 });
            da.UpdateCommand = cmd;

            string sel = "select A.CNP,codPacient,nume+'  '+prenume as [Nume Pacient],B.codBoala,numeBoala,C.codMedic,numeMedic+'  '+prenumeMedic as [Nume Medic],durataInternare,dataNasterii,greutate,specializare,durataInternare*pret as [Total Plata] " +
                   "from tPacienti as A inner join tBoli as B on A.codBoala = B.codBoala " +
                   " inner join tMedici as C on A.codMedic=C.codMedic  left join tBonuri as D on D.cnp=A.cnp " +
                       "order by codPacient";
            cmd = new SqlCommand(sel, con);
                    da.SelectCommand = cmd;
     
            return da;
        }

    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
