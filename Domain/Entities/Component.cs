using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Component : EntityBase
    {
        [Display(Name = "Материнская плата")]
        public string Motherboard { set; get; }

        [Display(Name = "Процессор")]
        public string Processor { set; get; }

        [Display(Name = "Видеокарта")]
        public string Videoadapter { set; get; }

        [Display(Name = "Звуковая карта")]
        public string SoundCard { set; get; }

        [Display(Name = "Накопитель")]
        public string StorageDevice { set; get; }

        [Display(Name = "Блок питания")]
        public string PowerUnit { set; get; }
    }
}
