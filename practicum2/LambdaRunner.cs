using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("timesThree :: met x={0} :: {1} \n", num1, timesThree(num1)); 
            
            Func<int, int, int, int> addN = (x, y, z) => x + y + z;
            output.AppendFormat("AddNumbers:: met x={0}, y={1}, z={2} :: {3} \n", num1, num2,num3, addN(num1,num2,num3));
            
            Func<int, bool> IsEven = x => x % 2 == 0;
            output.AppendFormat("IsEven:: met x={0} :: {1} \n", num1, IsEven(num1));
            
            Func<int, string> Num2String = x =>
            {
                switch (x)
                {
                    case 0:
                        return "zero"; break;
                    case 1:
                        return "one"; break;
                    case 2:
                        return "two"; break;
                    case 3:
                        return "three"; break;
                    case 4:
                        return "four"; break;
                    case 5:
                        return "five"; break;
                    case 6:
                        return "six"; break;
                    case 7:
                        return "seven"; break;
                    case 8:
                        return "eight"; break;
                    case 9:
                        return "nine"; break;
                    default:
                        return "undefined"; break;
                }
            };
            
            output.AppendFormat("Num2String:: met x={0} :: {1} \n", num1, Num2String(num1));
            
            Func<int, int ,int, bool> InBetween = (x, y, z) => ((x < y && y < z) || (z < y && y < x)) ;
            
            output.AppendFormat("InBetween:: met x={0}, y={1}, z={2} :: {3} \n", num1, num2, num3, InBetween(num1,num2,num3));

            
            Person p = new Person { Name = "Jan" };
            
            Action<Person> ResetName = (Person person) =>
            {
                p.Name = null;
            };

            ResetName(p);
            
            output.AppendFormat("ResetName :: daarna :: Name == null :: = {0}\n",p.Name == null);
            
            return output.ToString();
        }

    }
}
