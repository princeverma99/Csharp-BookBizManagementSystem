using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Books
    {
        public long ISBN { get; set; }

        public string Title { get; set; }

        public decimal? UnitPrice { get; set; }

        public int YearPublished { get; set; }

        public int? QOH { get; set; }
    }
}
