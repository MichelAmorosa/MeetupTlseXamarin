using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandalfApp6.Models
{

    public class CommunityMember
    {
        public string Name { get; set; }
        public string EpicQuote { get; set; }
        public Race Race { get; set; }
        public int HealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }

        public double HealthRatio
        {
            get
            {
                return HealthPoints / (double)MaxHealthPoints;
            }
        }

        public string DisplayHealth
        {
            get
            {
                return $"{HealthPoints} / {MaxHealthPoints}";
            }
        }

        public Xamarin.Forms.Color HealthColor
        {
            get
            {
                if (HealthRatio < 0.5)
                {
                    return Xamarin.Forms.Color.Red;
                }
                if (HealthRatio > 0.8)
                {
                    return Xamarin.Forms.Color.Green;
                }

                return Xamarin.Forms.Color.Transparent;
            }
        }
        
    }

    public enum Race
    {
        Human,
        Hobbit,
        Dwarf,
        Elf,
        Orc
    }

}
