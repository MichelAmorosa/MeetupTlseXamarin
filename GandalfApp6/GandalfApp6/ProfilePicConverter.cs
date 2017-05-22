using GandalfApp6.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GandalfApp6
{

    public class ProfilePicConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value.ToString().Length > 0)
            {
                var race = (Race)Enum.Parse(typeof(Race), value.ToString());
                switch (race)
                {
                    case Race.Dwarf:
                    case Race.Hobbit:
                        return "dwarfprofile.png";
                    case Race.Elf:
                        return "elfprofile.png";
                    case Race.Orc:
                    case Race.Human:
                    default:
                        return "humanprofile.png";
                }
            }
            else
            {
                return "humanprofile.png";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
