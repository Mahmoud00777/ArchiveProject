using ArchiveProject1.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveProject1.Classes
{
    internal class ConClass
    {
        public static string sqlQuery;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;

        //public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ArchiveDB1;Integrated Security=true;");
        public static SqlConnection con = new SqlConnection("Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";Integrated Security=False;User ID=" + Settings.Default.SQLLogin + ";Password=" + Settings.Default.SQLPassword + ";");

    }
}
