using System.Globalization;
using System.Text;

namespace Basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.WriteLine("Hello world!"); // Hello world!

            // -------------------------------------------- User interaction and variables --------------------------------------------
            Console.Write("What is your name: ");
            string? name = Console.ReadLine(); // read input from user and save in varibale called name. 
            Console.WriteLine($"Hello {name}");

            bool canVote = true;
            Console.WriteLine("Boolean Value {0}", canVote); // True

            // -------------------------------------------- Data types --------------------------------------------
            // integers
            Console.WriteLine("Biggest Interger {0}", int.MaxValue); // 2147483647
            Console.WriteLine("Smallest Interger {0}", int.MinValue); // -2147483648

            Console.WriteLine("Biggest Long {0}", long.MaxValue); // 9223372036854775807
            Console.WriteLine("Smallest Long {0}", long.MinValue); // -9223372036854775808

            decimal decPi = 3.141592653589793238462643383279502884197M;
            decimal decBigNum = 3.100000000000000000000000000000012000107M;

            Console.WriteLine("DEC : PI + BigNum {0}", decPi + decBigNum); // 6.2415926535897932384626433833

            Console.WriteLine("Biggest Decimal {0}", decimal.MaxValue); // 79228162514264337593543950335
            Console.WriteLine("Smallest Decimal {0}", decimal.MinValue); // -79228162514264337593543950335

            // floats
            Console.WriteLine("Biggest Float {0}", float.MaxValue); // 3.4028235E+38
            Console.WriteLine("Smallest Float {0}", float.MinValue); // -3.4028235E+38

            Console.WriteLine("Biggest Double {0}", double.MaxValue); // 1.7976931348623157E+308
            Console.WriteLine("Smallest Double {0}", double.MinValue); // -1.7976931348623157E+308

            double dblPi = 3.141592653589793;
            double dblBigNum = 3.100000000000000;

            Console.WriteLine("DOUBLE : PI + BigNum {0}", dblPi + dblBigNum); // 6.241592653589793

            // -------------------------------------------- Casting --------------------------------------------
            // implicit
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("20");
            double dblFromStr = double.Parse("1.342");

            Console.WriteLine("Bool from Str {0}", boolFromStr); // True
            Console.WriteLine("Int from Str {0}", intFromStr); // 20
            Console.WriteLine("Double from Str {0}", dblFromStr); // 1.342

            // to string
            string boolStrVal = boolFromStr.ToString();
            string intStrVal = intFromStr.ToString();

            Console.WriteLine("Data type {0}", boolStrVal.GetType());
            Console.WriteLine("Data type {0}", intStrVal.GetType());

            // explicit
            double dblNum = 12.412; // in that case data loss
            Console.WriteLine($"Double to Integer {(int)dblNum}");

            int intNum = 12;
            Console.WriteLine($"Integer to Long {(long)intNum}");

            Console.WriteLine($"Integer to Double {(double)intNum}");

            // -------------------------------------------- Formatting output --------------------------------------------
            Console.WriteLine("Currency : {0:c}", 23.455); // $23.45
            Console.WriteLine("Currency : {0:d4}", 23); // 0023
            Console.WriteLine("Currency : {0:f3}", 23.455432); // 23.455
            Console.WriteLine("Currency : {0:n4}", 23345); //23,345.0000

            // -------------------------------------------- String functions --------------------------------------------
            string str = "This is random string";
            Console.WriteLine("String Length : {0}", str.Length); // 21
            Console.WriteLine("String Contain is : {0}", str.Contains("is")); // True
            Console.WriteLine("Index of is : {0}", str.IndexOf("is")); // 2
            Console.WriteLine("Remove String : {0}", str.Remove(13, 6)); // This is randong
            Console.WriteLine("Insert String : {0}", str.Insert(15, "short ")); // This is random short string
            Console.WriteLine("Replace String : {0}", str.Replace("string", "new string")); // This is random new string
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)); //  -1

            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine("Pad Left: {0}", str.PadLeft(40)); //                     This is random string
            Console.WriteLine("Pad Right: {0}", str.PadRight(40)); // This is random string                  
            Console.WriteLine("Trim: {0}", str.Trim()); // This is random string
            Console.WriteLine("Uppercase: {0}", str.ToUpper()); // THIS IS RANDOM STRING
            Console.WriteLine("Lowercase: {0}", str.ToLower()); // this is random string

            // ---------- format strings
            string newStr = String.Format("{0} saw a {1} {2} in the {3}", "Pual", "rabbit", "eating", "field");
            Console.Write(newStr + "\n");

            // ---------- escape characters
            // \' \" \a \t \n
            Console.Write(newStr + "\n");
            Console.Write(newStr + "\t");

            // ---------- verbatim strings
            Console.WriteLine(@"No need to add escape characters");

            // -------------------------------------------- Arrays and For Loop --------------------------------------------
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("Fav Number is {0}", favNums[0]);

            string[] customers = ["Bob", "John", "Sue"]; // same type explict
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", i, customers[i]);
            }

            var employees = new[] { "Maki", "Paul", "Rick" }; // same type implicit
            for (int j = 0; j < employees.Length; j++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", j, employees[j]);
            }

            object[] rand = ["Bob", 21, 3.1, true];
            Console.WriteLine("Random Array[0] type {0}", rand[0].GetType()); // Random Array[0] type System.String
            Console.WriteLine("Random Array size {0}", rand.Length); // 4

            // multi dimensional array
            int[,] identity = new int[2, 2] { { 1, 0 }, { 0, 1 } };
            Console.WriteLine("Multi Dimensional Single value {0}", identity.GetValue(1, 0)); // 0

            for (int i = 0; i < identity.GetLength(0); i++)
            {
                for (int j = 0; j < identity.GetLength(0); j++)
                {
                    Console.WriteLine("{0}", identity[i, j]);
                }
                Console.WriteLine();
            }

            // -------------------------------------------- Functions --------------------------------------------
            int[] nums = [1, 2, 4, 6, 9, 5, 6, 8];
            PrintArray(nums, "Foreach");
            Console.WriteLine("------------------");

            Array.Sort(nums);
            PrintArray(nums, "Sort");

            Array.Reverse(nums);
            PrintArray(nums, "Reverse");

            Console.WriteLine("1 at index : {0}", Array.IndexOf(nums, 1)); // 1 at index : 7
            nums.SetValue(0, 1);

            int[] src = [1, 2, 3, 4];
            int[] dest = new int[2];
            int length = 2;
            Array.Copy(src, dest, length);
            PrintArray(nums, "Copy");

            Array other = Array.CreateInstance(typeof(int), 10);
            src.CopyTo(other, 5);
            foreach (int m in other)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }

            int[] f = [1, 2, 11, 14];
            Console.WriteLine("> : {0}", Array.Find(f, GT10)); // > : 11

            // -------------------------------------------- If / else / else if  --------------------------------------------
            // Relational Operator > < >= <= == != 
            // Logical Operator : && || !
            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elemantary school");
            }
            if ((age > 7) && (age <= 13))
            {
                Console.WriteLine("Go to middle school");
            }
            if ((age > 13) && (age <= 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 60))
            {
                Console.WriteLine("You shouldn't work");
            }
            else
            {
                Console.WriteLine("Work hard");
            }

            Console.WriteLine("! true = " + (!true));

            string msgDrive = "You can drive";
            string msgNotDrive = "You can't drive";

            string msg = age >= 16 ? msgDrive : msgNotDrive;
            Console.WriteLine(msg);

            string n1 = "john";
            string n2 = "john";
            if (n1.Equals(n2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }

            // -------------------------------------------- Switch  --------------------------------------------
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to day care");
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Go to preschool");
                    break;
                case 7:
                    Console.WriteLine("Go to masjid");
                    break;
                case 17:
                    Console.WriteLine("Go to high school");
                    break;
                default:
                    Console.WriteLine("Default case");
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Go to other school");

            // -------------------------------------------- While / Do While loop  --------------------------------------------
            // WHILE
            int e = 1;
            while (e <= 10)
            {
                Console.WriteLine(e);
                e++;
            }

            while (e <= 10)
            {
                if (e % 2 == 0)
                {
                    // Console.WriteLine(i);
                    e++;
                    continue;
                }
                if (e == 9) break;
                Console.WriteLine(e);
                e++;
            }

            // DO WHILE
            Random rnd = new();
            int secretNum = rnd.Next(1, 11);
            int guessNum = 0;
            Console.WriteLine("Random Number: {0}", secretNum);

            do
            {
                Console.WriteLine("Enter a number between 1 to 10 : ");
                guessNum = Convert.ToInt32(Console.ReadLine());

            } while (secretNum != guessNum);

            Console.WriteLine("You guess the number: {0}", secretNum);

            // -------------------------------------------- Exception Handling  --------------------------------------------
            double a = 5;
            double b = 0;

            try
            {
                Console.WriteLine("Do Division {0}", DoDivision(a, b));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by 0");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occur");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleanup");
            }

            // -------------------------------------------- String buidlers  --------------------------------------------
            StringBuilder sb = new("Random Text");
            StringBuilder sb1 = new("Other information", 256);
            Console.WriteLine(sb);
            Console.WriteLine("Capacity {0}", sb.Capacity);
            Console.WriteLine("Length {0}", sb.Length);

            sb1.AppendLine("\n More stuff");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "John";
            sb1.AppendFormat(enUS, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb1.ToString());
            sb.Replace("text", "new text");
            Console.WriteLine(sb.ToString());
            sb1.Clear();
            sb1.Append(sb);
            Console.WriteLine(sb1);

            sb1.Insert(11, " that's great");
            sb1.Remove(11, 7);

            // -------------------------------------------- Functions / Methods --------------------------------------------
            // Functions are used to avoid code duplication, provides
            // organization and allows use to simulate different
            // systems
            // <Access Specifier> <Return Type> <Method Name>(Parameters)
            // { <Body> }

            // Access Specifier determines whether the function can
            // be called from another class
            // public : Can be accessed from another class
            // private : Can't be accessed from another class
            // protected : Can be accessed by class and derived classes
            SayHello();

            // ----- Passing By Value -----
            // By default values are passed into a method and not a reference to the variable passed
            // Changes made to those values do not effect the variables outside of the method
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));

            // Even though the value for x changed in method it remains unchanged here
            Console.WriteLine("x = {0}", x);

            // ----- Out Parameter -----
            // A parameter passed with out has its value assigned in the method
            DoubleIt(15, out int solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            // ----- Pass By Reference -----
            int g = 10;
            int h = 20;
            Console.WriteLine("Before Swap g : {0} h : {1}", g, h);

            Swap(ref g, ref h);

            Console.WriteLine("After Swap g : {0} h : {1}", g, h);

            // ----- Params -----
            // Able to pass a variable amount of data of the same data type into a
            // method using params. You can also pass in an array.
            Console.WriteLine("1 + 2 + 3 = {0}", GetSumMore(1, 2, 3));

            // ----- Named Parameters -----
            // Pass values in any order if you used named parameters
            PrintInfo(zipCode: 15147, name: "Derek Banas");

            // ----- Method Overloading -----
            // Define methods with the same name that will be called depending on what data is sent automatically
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.5));
            Console.WriteLine("5 + 4 = {0}", GetSum2(5, 4));
            Console.WriteLine("5 + 4 = {0}", GetSum2("5", "4"));

            // -------------------------------------------- Datetime / Timespan --------------------------------------------
            // Datetime
            DateTime d = new(1990, 10, 03);
            Console.WriteLine("Day of Week : {0}", d.DayOfWeek);

            d = d.AddDays(4);
            d = d.AddMonths(1);
            d = d.AddYears(1);
            Console.WriteLine("New Date : {0}", d.Date);

            // Timespan
            TimeSpan lunchTime = new(01, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            // -------------------------------------------- ENUM --------------------------------------------
            CarColor blueCar = CarColor.Blue;
            PaintCar(blueCar);
        }

        // ----- FUNCTIONS -----
        static void PrintArray(int[] arr, string msg)
        {
            // -------------------------------------------- Foreach loop --------------------------------------------
            foreach (int k in arr)
            {
                Console.WriteLine("{0} : {1}", msg, k);
            }
        }

        public static bool GT10(int number)
        {
            return number > 10;
        }

        public static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Can't divide by zero.");
            }
            return x / y;
        }

        private static void SayHello()
        {
            string? name;
            Console.Write("What is your name : ");

            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        static void Swap(ref int num3, ref int num4)
        {
            (num4, num3) = (num3, num4);
        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums.Select(v => (int)v))
            {
                sum += i;
            }
            return sum;
        }

        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        // ----- Method Overloading -----
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }


        // ------ ENUMS ------
        // An enum is a custom data type with  key value pairs. They allow you to use symbolic names to represent data
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

    }
}