using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon_DevExpress
{
    class SqlBaglanti
    {

        public SqlConnection baglanti()
        {

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-38ER4CK\SQLEXPRESS;Initial Catalog=TicariOtomasyon;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
