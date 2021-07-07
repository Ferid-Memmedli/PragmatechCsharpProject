using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     /*
     * ele bir class dizayn etmelisiz ki , daxilindeki method 3 parametr qebul edecek
     * ilk ikisi int tipinde ededler olacaq , classin ucuncu parametri ise qarsilashtirma emeliyyatini yerine yetirecek
     * classlarin instance-i olacaq yeni bir defe == dirmini yoxlayan classin instance-i daxil edile bilmeli bir defe
     * boyuk ve ya kicik olmasini yoxlayan classin instance-i
     * 
     * bool CompareTo(int a, int b, new Instance1()) ==
     * bool CompareTo(int a, int b, new Instance2()) > or <
     */
    public static class Compare
    {
        public static bool CompareTo(int a, int b, IYoxlama c) 
        {
            return c.SayYoxlama(a, b);
        }
    }
    public class Beraberlik : IYoxlama
    {
        public bool SayYoxlama(int say1, int say2)
        {
            return say1 == say2;
        }
    }
    public class Boyukluk : IYoxlama
    {
        public bool SayYoxlama(int say1, int say2)
        {
            return say1 > say2;
        }
    }
    public interface IYoxlama
    {
        bool SayYoxlama(int say1,int say2);
    }
}
