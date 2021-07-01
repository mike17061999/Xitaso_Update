using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Xitaso_Webapplikation.Models
{
    public class Analysekategorie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Frage> Questions { get; set; }
    }
}