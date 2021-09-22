using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppPV
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {

            SqlConnection cn = new SqlConnection("Data Source=CORPO134\\SICHOCHOA;Initial Catalog=AppPV;user=sa;pwd=Sanmartin123!;Integrated Security=False;");
            cn.Open();
            return cn;
        }
    }
}
