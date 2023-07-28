using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AspNet.Models
{
    public partial class BusTable
    {
        [Key]
        public int BusIdx { get; set; }

        public string BusNum { get; set; } = null!;

        public int BusCnt { get; set; }

        public int BusGap { get; set; }

        public int BusNowIn { get; set; }
    }
}
