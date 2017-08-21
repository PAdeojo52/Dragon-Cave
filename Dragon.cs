using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Dragon : Room
    {
        private static string[,] baseMap;

        //public static string[,] BaseMap1 { get => baseMap; set => baseMap = value; }

        public Dragon(string[,] baseMap) : base(baseMap)
        {

        }

        
    }
}
