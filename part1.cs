using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(String[] args)
        {

            //Console.WriteLine("hello world!!");
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Console.Write("What is your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");
            // --VARIABLES--
            // bool canIVote = true;
            //int a = int.MaxValue;
            //Console.WriteLine($"Biggest Integer : {a}");
            //Console.WriteLine("Smallest Integer : {0}", int.MinValue,int.MaxValue);
            //Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            //Console.WriteLine("Smallest Long : {0}", long.MinValue);
            //decimal decPiVal =3.1415926535897932384626433832M; //28 digits worth of precision in decimal part
            //decimal decBigNum = 3.00000000000000000000000000000000000011M;
            //Console.WriteLine("DEC: PI + bigNum ={0}",decPiVal+decBigNum);
            //Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            //Console.WriteLine("Biggest Double : {0}",Double.MaxValue);
            //double dblPiVal = 3.14159265358979;
            //double dblBigNum = 3.0000000000000002;
            //Console.WriteLine("DBL : PI + bigNum= {0}",dblPiVal+dblBigNum);
            //Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            //float fltPiVal = 3.141592F;
            //float fltBigNum = 3.000002F;
            //Console.WriteLine("FLT : PI + bigNum= {0}", fltPiVal + fltBigNum); //Precision of float is 6 digits after decimal
            //float f = 0.12345678919191F;
            // Console.WriteLine(f);
            //Other data types:
            /*
             * byte : 8 bit unsigned int 0 to 255
             * char : 16 bit unicode character
             * sbyte: 8 bit signed int 128 to 127
             * short : 16 bit signed int -32,768 to 32,767
             * uint : 32 bit unsigned int 0 to 4,294,967,295
             * ulong: 64 bit unsigned int 0 to 18,446,744,073,709,551,615
             * ushort : 16 bit unsigned int 0 to65,535
             */
            /*
            bool boolfromstr = bool.Parse("true");
            Console.WriteLine(boolfromstr);
            int intfromstr = int.Parse("100");
            Console.WriteLine(intfromstr);
            double dblFromStr = double.Parse("1.234");
            Console.WriteLine(dblFromStr);
            Console.WriteLine($"type of 1.234 is: {dblFromStr.GetType()}");
            string strVal = dblFromStr.ToString();
            Console.WriteLine($"Data type: {strVal.GetType()}");
            double dblNum = 12.345;
            Console.WriteLine($"Integer: {(int)dblNum}"); //Explicit Conversion: loosing decimal places
            //implicit convesrsion: 
            int intNum = 10;
            long longNum = intNum;
            */
            //Console.WriteLine("Currency : {0:c}",23.455);
            //Console.WriteLine("Pad with 0s: {0:d4}",23);
            //Console.WriteLine("3 Decimals : {0:f3}",23.45555);
            //Console.WriteLine("Commas : {0:n2}",2121230000);
            //String
            //string randstring = "This is a String";
            //Console.WriteLine("String Length : {0}",randstring.Length);
            //Console.WriteLine("String Contains is : {0}",randstring.Contains("is"));
            //Console.WriteLine("Index of is : {0}", randstring.IndexOf("is"));
            //Console.WriteLine("Remove String : {0}", randstring.Remove(10,6));
            //Console.WriteLine("Insert String : {0}",randstring.Insert(10, "short "));
            //Console.WriteLine("Replace String : {0}",randstring.Replace("String","Sentence"));
            //Console.WriteLine("Compare A to B : {0}",string.Compare("k", "b",StringComparison.OrdinalIgnoreCase));
            ///*Compare strings and ignore case
            // * < 0 : str1 preceeds str2 (example: "a","b" = result is < 0, here -1)
            // * = 0 : they are equal
            // * > 0: str2 preceeds str1
            // */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("A = a : {0}",String.Equals("A","a",StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad Left : {0}",
            //    randstring.PadLeft(20,'.'));
            //Console.WriteLine("Pad Right : {0}",
            //   randstring.PadRight(20, '.'));
            //Console.WriteLine("Trim: {0}",
            //    randstring.Trim());
            //Console.WriteLine("UpperCase : {0}",randstring.ToUpper());
            //Console.WriteLine("LowerCase : {0}", randstring.ToLower());
            //string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            //Console.WriteLine(newString);
            //Console.WriteLine("{0} saw a {1} {2} in the {3}", "Alice", "rabbit", "eating", "field");
            //Console.Write(newString + "\n");
            //string output = $"{ "Alice"} saw a { "rabbit"} { "eating"} in the { "field"}";
            //Console.WriteLine(output);
            //Console.WriteLine($"{"Alice"} saw a {"Wonderland"}");

            //string name = "Alice";
            //string activity = "eating";
            //string subject = "dinosaur";
            //string location = "field";

            //string output2 = name + " saw a " + subject + " " + activity + " in the " + location;
            //Console.WriteLine(output2);
            ////\' \" \\ \t \a
            //Console.WriteLine(@"Exactly what I typed\n"); // Verbatim Strings

            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0: {0}", favNums[0]);
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine();
            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
            Console.WriteLine("randomArray 1: {0}", randomArray[1].GetType());
            Console.WriteLine("randomArray 2: {0}", randomArray[2].GetType());
            Console.WriteLine(); 
            Console.WriteLine("Array Size: {0}", randomArray.Length);
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array : {0} : Value : {1} ", j, randomArray[j]);
            }
            Console.WriteLine("-----------------------------------");
            string[,] custName = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Sam" } };
            Console.WriteLine(custName.GetValue(1, 0));
            Console.WriteLine(custName.GetLength(0));
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < custName.GetLength(0); j++)
            {
                for (int k = 0; k < custName.GetLength(0); k++)
                {
                    Console.WriteLine("{0}", custName[j, k]);
                }
                Console.WriteLine();
            }
            

        }
    }
}
