using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP_222_2_.NET.Model
{
    class MonthData
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Animal
    {
        public string Name;
        public MonthData[] Months
        {
            get
            {
                return new MonthData[]
                {
                    new MonthData{Id= 1, Name = "январь" },
                    new MonthData{Id= 2, Name = "февраль" },
                    new MonthData{Id= 3, Name = "март" },
                    new MonthData{Id= 4, Name = "апрель" },
                    new MonthData{Id= 5, Name = "май" },
                    new MonthData{Id= 6, Name = "июнь" },
                    new MonthData{Id= 7, Name = "июль" },
                    new MonthData{Id= 8, Name = "август" },
                    new MonthData{Id= 9, Name = "сентябрь" },
                    new MonthData{Id= 10, Name = "октябрь" },
                    new MonthData{Id= 11, Name = "ноябрь" },
                    new MonthData{Id= 12, Name = "декабрь" }
                };
            }

        }

        public Animal()
        {

        }
    }
}


