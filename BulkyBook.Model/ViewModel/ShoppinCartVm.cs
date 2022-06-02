using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Model.ViewModel
{
    public class ShoppinCartVm
    {
        public Product Product { get; set; }

        [Range(1,1000, ErrorMessage = " Range Should be Between 1 to 1000")]
        public int Count { get; set; }
    }
}
