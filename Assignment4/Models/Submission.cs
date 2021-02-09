using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Submission
    {
        //I required name and restaurant because I wanted to prevent completely blank submissions.
        [Required(ErrorMessage = "Please enter your name.")]
        public string user { get; set; }

        [Required(ErrorMessage = "Please enter the restaurant name.")]
        public string name { get; set; }

#nullable enable
        public string? dish { get; set; }/* = "It's all tasty!";*/

#nullable enable
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string? phone { get; set; }
    }
}
