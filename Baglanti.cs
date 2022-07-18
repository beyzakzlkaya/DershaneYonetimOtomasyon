using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dershaneOtomasyon
{
    class Baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-6GO1P98;Initial Catalog=dershaneYonetim;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}