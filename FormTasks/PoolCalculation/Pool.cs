using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolCalculation
{
    public static class Pool
    {
        /// <summary>
        /// Hovuzun Hecmi Tapilmasi
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns>decimal : Hovuzun Hecmi </returns>
        public static decimal Capacity(decimal depth, decimal length, decimal width)
        {
            return depth * length * width;
        }

        /// <summary>
        /// Hovuzun nece deqiqede dolmasinin tapilmasi
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="waterPipeChargingTime"></param>
        /// <returns>decimal : Hovuzun Dolma Muddeti</returns>
        public static decimal ChargingTime(decimal capacity, params decimal[] waterPipeChargingTime)
        {
            decimal time = 0;
            foreach (var item in waterPipeChargingTime)
                time += item;
            return capacity / time;
        }
    }
}
