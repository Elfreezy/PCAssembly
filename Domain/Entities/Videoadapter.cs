using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Videoadapter : ProductBase
    {
        [Display(Name = "Интерфейс")]
        public string Interface { set; get; }
    }
}
