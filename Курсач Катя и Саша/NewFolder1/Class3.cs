using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Катя_и_Саша.NewFolder1
{
    class Class3:Interface2
    {
        public string Name;
        public int Time;

        public string _Name;
        public int _Time;

        public Class3()
        {
            _Name = Name;
            _Time = Time;
        }


        public string name { get => _Name; set => _Name = value; }
        public int time { get => _Time; set => _Time = value; }
    }
}
