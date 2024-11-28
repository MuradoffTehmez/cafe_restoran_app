using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("Modlar")]
    public class Modlar
    {
        public int Id { get; set; }


        public int IstifadeciID { get; set; }


        public string FormName { get; set; }


        public string ControlName { get; set; }


        public string ControlCaption { get; set; }


    }

}
