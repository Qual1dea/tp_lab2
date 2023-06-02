using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Laba_2.Models
{
    public class Person
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { get; set; }

        [Display(Name = "Имя Фамилия")]
        public string Name { get; set; }

        [Display(Name = "Заказ")]
        public string Order { get; set; }

        [Display(Name = "количество")]
        public string Quantity { get; set; }

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Детали")]
        public string Details { get; set; }
    }
}