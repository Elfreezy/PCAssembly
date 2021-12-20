using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Processor : ProductBase
    {
        // Socket, Core, CountCore, MaxNumberThreads, BaseFrequencyProcessor,
        // MaxFrequencyProcessor, TypeMemory, MaxFrequencyMemory, MaxSizeMemory
        // MaxTemperature, Multithreading

        [Display(Name = "Сокет")]
        public string Socket { set; get; }

        /*
        [Display(Name = "Ядро")]
        public string Core { set; get; }

        [Display(Name = "Количество ядер")]
        public int CountCore { set; get; }

        [Display(Name = "Максимальное количество потоков")]
        public int MaxNumberThreads { set; get; }

        [Display(Name = "Базовая частота процессора")]
        public int BaseFrequencyProcessor { set; get; }

        [Display(Name = "Максимальная частота процессора")]
        public int MaxFrequencyProcessor { set; get; }

        [Display(Name = "Тип памяти")]
        public string TypeMemory { set; get; }

        [Display(Name = "Максимальная частота памяти")]
        public int MaxFrequencyMemory { set; get; }

        [Display(Name = "Максимальный объем памяти")]
        public int MaxSizeMemory { set; get; }

        [Display(Name = "Максимальная температура")]
        public int MaxTemperature { set; get; }

        [Display(Name = "Многопоточность")]
        public bool Multithreading { set; get; }
        */
    }
}
