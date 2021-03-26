using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Катя_и_Саша.NewFolder1
{
    class Class1 //класс для одноо самолётика который летает
    {
        public static List<Interface1> knapsack(string[] name_spisok, int[] time_0, int[] time_a, int[] time_b, int[] time_c, int[] time_d, int[] time_e)
        {
            List<Interface1> Spisok_1 = new List<Interface1>();

            int min = 0;
            int n = 0; int n1;

            for (int w = 0; w <= 5; w++)
            {
                n1 = n;
                min= Math.Max (time_0[n], time_a[n]);
                if (!((time_0[n] == 0)&(n1==0)))
                    if (time_0[n] <= min)
                    {
                        min = time_0[n];
                        n = 0;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_0[n]) });
                    }
                if (!((time_a[n] == 0) & (n1 == 1)))
                    if (time_a[n] <= min)
                    {
                        min = time_a[n];
                        n = 1;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_a[n]) });
                    }
                if (!((time_b[n] == 0) & (n1 == 2)))
                    if (time_b[n] <= min)
                    {
                        min = time_b[n];
                        n = 2;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_b[n]) });
                    }
                if (!((time_c[n] == 0) & (n1 == 3)))
                    if (time_c[n] <= min)
                    {
                        min = time_c[n];
                        n = 3;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_c[n]) });
                    }
                if (!((time_d[n] == 0)&(n1 == 4)))
                    if (time_d[n] <= min)
                    {
                        min = time_d[n];
                        n = 4;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_d[n]) });

                    }
                if (!((time_e[n] == 0)&(n1 == 5)))
                    if (time_e[n] <= min)
                    {
                        min = time_e[n];
                        n = 5;
                        Spisok_1.Add(item: new Class2() { name = (name_spisok[n]), time = (time_e[n]) });
                    }
            }
            return Spisok_1;
        }
    }
}

