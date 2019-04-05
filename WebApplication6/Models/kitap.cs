using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public DateTime KitapBasimTarihi { get; set; }
        public int YazarId { get; set; }
        public int KitapTuruId { get; set; }
        public virtual yazar Yazari { get; set; }
        public virtual kitapturu KitabınTuru { get; set; }

    }
}