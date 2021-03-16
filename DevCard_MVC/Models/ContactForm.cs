using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3 , ErrorMessage = "حداقل طول نام ، 3 کاراکتر است")]
        [MaxLength(100 , ErrorMessage = "حد اکثر طول نام ، 3 کاراکتر است")]
        public string name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "این ایمیل صحیح نیست")]
        public string Email { get; set; }
        public string message { get; set; }
        public string services { get; set; }

    }
}
