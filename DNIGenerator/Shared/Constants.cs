using DNIGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNIGenerator.Shared
{
    public class Constants
    {
        public static List<Letter> letters = new List<Letter>
        {
            new Letter{ Character = "T", Value = 0 },
            new Letter{ Character = "R", Value = 1 },
            new Letter{ Character = "W", Value = 2 },
            new Letter{ Character = "A", Value = 3 },
            new Letter{ Character = "G", Value = 4 },
            new Letter{ Character = "M", Value = 5 },
            new Letter{ Character = "Y", Value = 6},
            new Letter{ Character = "F", Value = 7},
            new Letter{ Character = "P", Value = 8},
            new Letter{ Character = "D", Value = 9},
            new Letter{ Character = "X", Value = 10},
            new Letter{ Character = "B", Value = 11},
            new Letter{ Character = "N", Value = 12},
            new Letter{ Character = "J", Value = 13},
            new Letter{ Character = "Z", Value = 14},
            new Letter{ Character = "S", Value = 15},
            new Letter{ Character = "Q", Value = 16},
            new Letter{ Character = "V", Value = 17},
            new Letter{ Character = "H", Value = 18},
            new Letter{ Character = "L", Value = 19},
            new Letter{ Character = "C", Value = 20},
            new Letter{ Character = "K", Value = 21},
            new Letter{ Character = "E", Value = 22}
        };
    }
}
