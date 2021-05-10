using System;

namespace practicum2
{
    public class CheckRunner
    {
        public static void CheckAllMethods(int num1, int num2, int num3)
        {
            Func<int, int> timesThree = x => 3 * x;
            Func<int, int, int, int> addN = (x, y, z) => x + y + z;
            Func<int, bool> IsEven = x => x % 2 == 0;
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
            Func<int, int ,int, bool> InBetween = (x, y, z) => ((x < y && y < z) || (z < y && y < x)) ;
            
            Person p = new Person { Name = "Jan" };
            Person p2 = new Person { Name = "Jan" };
            
            Action<Person> ResetName = (Person person) =>
            {
                p.Name = null;
            };

            ResetName(p);
            Methods.ResetName(p2);
            
            if (timesThree(num1) != Methods.TimesThree(num1)) throw new Exception("NOT OK");
            if (addN(num1, num2, num3) != Methods.AddNumbers(num1, num2, num3)) throw new Exception("NOT OK");
            if (IsEven(num1) != Methods.IsEven(num1)) throw new Exception("NOT OK");
            if (Num2String(num1) != Methods.Num2String(num1)) throw new Exception("NOT OK");
            if (InBetween(num1, num2, num3) != Methods.InBetween(num1, num2, num3)) throw new Exception("NOT OK");
            if (!(p.Name == p2.Name && p.Name == null)) throw new Exception("NOT OK");
        }
    }
}