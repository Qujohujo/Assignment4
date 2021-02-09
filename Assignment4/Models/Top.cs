using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Top
    {

        public Top(int setRank)
        {
            rank = setRank;
        }

        [Required]
        public int rank { get; }

        [Required]
        public string name { get; set; }

#nullable enable
        public string? dish { get; set; }/* = "It's all tasty!";*/

        [Required]
        public string address { get; set; }

#nullable enable
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string? phone { get; set; }

#nullable enable
        public string? website { get; set; } = "Coming soon.";





        public static Top[] GetTops()
        {
            Top rank1 = new Top(1)
            {
                name = "Sweeto Burrito",
                dish = "Buff Chick",
                address = "1990 N. State St. Orem, UT",
                phone = "(801) 225-1178",
                website = "https://sweetoburrito.com"
            };

            Top rank2 = new Top(2)
            {
                name = "Bombay House",
                //dish = "",
                address = "463 N University Ave, Provo, UT",
                phone = "(801) 373-6677",
                website = "https://bombayhouse.com/"
            };

            Top rank3 = new Top(3)
            {
                name = "Black Sheep Cafe",
                //dish = "",
                address = "19 N University Ave, Provo, UT",
                phone = "(801) 607-2485",
                website = "https://blacksheepcafe.getbento.com/"
            };

            Top rank4 = new Top(4)
            {
                name = "J Dawgs",
                dish = "Polish",
                address = "858 700 E, Provo, UT",
                phone = "(801) 373-3294",
                website = "https://jdawgs.com/"
            };

            Top rank5 = new Top(5)
            {
                name = "Brasas Mexican Grill",
                //dish = "",
                address = "227 Cougar Blvd, Provo, UT",
                phone = "(801) 377-2565",
                //website = ""
            };

            return new Top[] { rank1, rank2, rank3, rank4, rank5 };
        }
    }
}