using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
   public class Sum  
    {
        public int x;
        public int y;

        public Sum(int x,int y) 
        {
            this.x = 7;
            this.y = 8;
        }
        public Sum() : this(6, 7)
        {
            var answer = x + y;
        }
    }
}

