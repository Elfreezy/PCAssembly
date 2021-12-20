using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public abstract class ProductBase : EntityBase
    {
        [Required(ErrorMessage = "Заполните название продукта")]
        [Display(Name = "Название продукта")]
        public override string Title { set; get; } = "Заголовок";

        [Display(Name = "Краткое описание продукта")]
        public override string Subtitle { set; get; } = "Краткое описание";

        [Display(Name = "Описание продукта")]
        public override string Text { set; get; } = "Содержание";

        [Required(ErrorMessage = "Заполните модели продукта")]
        [Display(Name = "Модель продукта")]
        public virtual string ModelName { set; get; } = "Модель";

        [Required(ErrorMessage = "Заполните дату выпуска продукта")]
        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        public virtual string DateCreated { set; get; } = "Дата выпуска";

        [Required(ErrorMessage = "Заполните производителя продукта")]
        [Display(Name = "Производитель продукта")]
        public virtual string Maker { set; get; } = "Производитель";

        [Required(ErrorMessage = "Заполните цену продукта")]
        [Display(Name = "Цена продукта")]
        public virtual string Price { set; get; } = "Цена продукта";
    }
}
