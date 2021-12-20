using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class StorageDevice : ProductBase
    {
        [Display(Name = "Форм-фактор")]
        public string FormFactor { set; get; }
    }
}
