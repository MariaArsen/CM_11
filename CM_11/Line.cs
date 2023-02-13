using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_11
{
    struct Line
    {
        double k;
        double b;
    
     public Line(double k, double b)
      {
         this.k = k;
         this.b = b;
       }
    public string Root()
       {
        if ((k == 0) && (b == 0))
            return "Решением уравнения является любое число";
        else if ((k == 0) && (b != 0))
            return "Уравнение решений не имеет";
        double x = (b / k);
            return $"Решение уравнения - {x}";
       }
    }
}

