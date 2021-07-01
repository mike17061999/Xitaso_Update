using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Xitaso_Webapplikation.Models
{
    public class Frage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IstBewertung { get; set; }
        public int SollBewertung { get; set; }
    }
}