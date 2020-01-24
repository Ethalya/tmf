using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ComboBoxViewModel
    {
        public List<string> Role { get; set; }
        public List<string> Rank { get; set; }
        public List<string> Serv { get; set; }
 
        public ComboBoxViewModel()
        {
            Role = new List<string>()
            {
                "Top",
                "Mid",
                "Jungler",
                "Support",
                "ADC",

            };

            Rank = new List<string>()
            {
                "Iron",
                "Bronze",
                "Silver",
                "Gold",
                "Platinum",
                "Diamond",
                "Master",
                "Grandmaster",
                "Challenger",

            };
            Serv = new List<string>()
            {
                "Brazil",
                "People's Republic of China",
                "EUNE",
                "Europe West",
                "Japan",
                "Republic of Korea",
                "Latin America North",
                "Latin America South",
                "North America",
                "Oceania",
                "Philippines",
                "Russia",
                "Singapore and Malaysia",
                "Thailand",
                "Turkey",
                "Taiwan",
                "Vietnam",
            };
        }
        

    }
}
