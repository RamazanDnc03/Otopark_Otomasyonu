using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOPARK_OTOMASYONU06.Model
{
    public class abonman
    {
     public int Id { get; set; }
     public int sahibId { get; set; }
     public DateTime abonmanStart { get; set; }
     public DateTime abonmanEnd { get; set; }
     public string abonmanType { get; set; }
     public string plaka { get; set; }
        internal static void Add(entry_exit asdff)
        {
            throw new NotImplementedException();
        }
    }
}
