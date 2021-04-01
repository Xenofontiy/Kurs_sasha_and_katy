using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач_Катя_и_Саша.NewFolder1
{
    public class Class2:Interface1
    {
        string _name;
        int _timeA;
        int _timeB;
        int _timeC;
        int _timeD;
        int _timeI;
        int _timeF;
        public Class2(string name, int timeA, int timeB, int timeC, int timeD, int timeI, int timeF)
        {
            _name = name;
            _timeA = timeA;
            _timeB = timeB;
            _timeC = timeC;
            _timeD = timeD;
            _timeI = timeI;
            _timeF = timeF;
        }
        public string Name { get => _name; set => _name = value; }
        public int TimeA { get => _timeA; set => _timeA = value; }
        public int TimeB { get => _timeB; set => _timeB = value; }
        public int TimeC { get => _timeC; set => _timeC = value; }
        public int TimeD { get => _timeD; set => _timeD = value; }
        public int TimeI { get => _timeI; set => _timeI = value; }
        public int TimeF { get => _timeF; set => _timeF = value; }
    
    /*string _Name; int _Time;

    public Class2(string Name, int Time)
    {
        _Name = Name;
        _Time = Time;
    }

    public string name { get => _Name; set => _Name = value; }
    public int time { get => _Time; set => _Time=value; }*/
}
}
