namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static string Add(double num1, double num2, bool sum)
        {
            if (sum == true && num1 + num2 != 1)
            {
                return $"{num1 + num2} dollars";
            }

            else if (sum == true && num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }

            else
            {
                return $"{num1 + num2}";
            }
        }
    }
}
