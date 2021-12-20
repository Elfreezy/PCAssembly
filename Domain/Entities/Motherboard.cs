using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Motherboard : ProductBase
    {
        [Display(Name = "Гнездо процессора")]
        public string ProcessorSocket { set; get; }

        [Display(Name = "Интерфейс видеокарты")]
        public string VideoadapterInterface { set; get; }

        [Display(Name = "Форм-фактор ПЗУ")]
        public string FormFactorStorageDevice { set; get; }

        [Display(Name = "Форм-фактор блока питания")]
        public string FormFactorPowerUnit { set; get; }

        [Display(Name = "Форм-фактор звуковой карты")]
        public string FormFactorSoundCard { set; get; }
    }
}
