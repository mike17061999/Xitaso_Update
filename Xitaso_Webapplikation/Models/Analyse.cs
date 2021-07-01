using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Xitaso_Webapplikation.Models
{
    public class Analyse
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime LastChanged { get; set; }
        public List<Analysekategorie> Analysekategorien { get; set; }
    }
}