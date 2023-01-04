using Computations.Patterns;
using Newtonsoft.Json;
using System;

namespace Computations.Mathematical.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Size  :  ");
            int size = 5;
            string output = "";

            output = "Pattern No.25\n";
            output += new Pattern25().Create(size) + "\n";

            output += "Pattern No.24\n";
            output += new Pattern24().Create(size) + "\n";

            output += "Pattern No.23\n";
            output += new Pattern23().Create(size) + "\n";

            output += "Pattern No.22\n";
            output += new Pattern22().Create(size) + "\n";

            output += "Pattern No.21\n";
            output += new Pattern21().Create(size) + "\n";


            output += "Pattern No.20\n";
            output += new Pattern20().Create(size) + "\n";

            output += "Pattern No.19\n";
            output += new Pattern19().Create(size) + "\n";

            output += "Pattern No.18\n";
            output += new Pattern18().Create(size) + "\n";

            output += "Pattern No.17\n";
            output += new Pattern17().Create(size) + "\n";

            output += "Pattern No.16\n";
            output += new Pattern16().Create(size) + "\n";

            output += "Pattern No.15\n";
            output += new Pattern15().Create(size) + "\n";

            output += "Pattern No.14\n";
            output += new Pattern14().Create(size) + "\n";

            output += "Pattern No.13\n";
            output += new Pattern13().Create(size) + "\n";

            output += "Pattern No.12\n";
            output += new Pattern12().Create(size) + "\n";

            output += "Pattern No.11\n";
            output += new Pattern11().Create(size) + "\n";

            output += "Pattern No.10\n";
            output += new Pattern10().Create(size) + "\n";

            output += "Pattern No.9\n";
            output += new Pattern9().Create(size) + "\n";

            output += "Pattern No.8 \n";
            output += new Pattern8().Create(size) + "\n";

            output += "Pattern No.7 \n";
            output += new Pattern7().Create(size) + "\n";

            output += "Pattern No.6 \n";
            output += new Pattern6().Create(size) + "\n";

            output += "Pattern No.5 \n";
            output += new Pattern5().Create(size) + "\n";

            output += "Pattern No.4 \n";
            output += new Pattern4().Create(size) + "\n";

            output += "Pattern No.3: \n";
            output += new Pattern3().Create(size) + "\n";

            output += "Pattern No.2: \n";
            output += new Pattern2().Create(size) + "\n";

            output += "Pattern No.1: \n";
           // var pattern1 = new Pattern1();
            output += new Pattern1().Create(size) + "\n";

            Console.WriteLine(output);
         

            //output += "flipped right tringle \n";
            for (int i = 1; i <= size; i++)
            {
                for (int space=1; space <= size - i; space++)
                {
                    output += " ";
                }
                for (int k=1; k<=i;k++)
                {
                    output += "*";
                }
                output += "\n";
            }

            //output += "flipped inverted  right tringle \n ";
            for (int i = 1; i <= size; i++)
            {
                for(int space = 1; space <= i-1; space++)
                {
                    output += " ";
                }
                for (int k = i; k <= size; k++)
                {
                    output += "*";
                }
                output += "\n";
            }

            //output +="a right triangle \n";
            for (int i = 1; i <= size; i++)
            {
                for(int j =1; j<=i; j++)
                {
                    output +="*";
                }
                output += "\n";
            }

            //output +="inverted right tringle \n";
            for (int i = 1; i <= size; i++)
            {
                for (int j = i; j <= size; j++)
                {
                    output += "*";
                }
                output += "\n";
            }


            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Iterating 2D Array FOREACH");
            string[,] user =
                {
                {"Maris", "maris123" },
                {"Richard", "richard123" },
                {"Nonon", "nonon123" }
                };

            foreach(string key in user)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Nested FOR LOOP");
            for (int row = 0; row < user.GetLength(0); row++)
            {
               for(int col = 0; col < user.GetLength(1); col++)
                {
                    Console.WriteLine(user[ row, col]);
                } 
                Console.WriteLine();
            }

            Console.ReadKey();
            string oddString = "";
            for (int num = 1; num <= 10; num++)
            {
                var odd = num % 2;
                if (odd != 0)
                {
                    oddString += (num + " ");
                }
            }
            Console.WriteLine(oddString);
            

            Console.ReadKey();
            Console.WriteLine("CalculatingMean");
            var calculatingMean4 = new CalculatingMean();
            int[] arr7 = { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
            var Mean4 = calculatingMean4.GetMean(arr7);
            Console.WriteLine("GetMean   =  " + Mean4);


            Console.ReadKey();
            Console.WriteLine("AverageOfElementAWholeNumber");
            var averageOfElementAWholeNumber = new AverageOfElementAWholeNumber();
            int[] arr4 = { 2,4,3,3,5};
            var wholeAverage = averageOfElementAWholeNumber.IsAverageWholeNumber(arr4);
            Console.WriteLine("IsAverageWholeNumber   =  " + wholeAverage);


            Console.ReadKey();
            Console.WriteLine("EliminatingOddNumbersWithinAnArray");
            var eliminatingOddNumbersWithinAnArray = new rEliminatingOddNumbersWithinAnArray();
            int[] arr3 = { 2, 3, 4, 5, 6, 7, 8 };
            var evenArrays = eliminatingOddNumbersWithinAnArray.Get(arr3);
            Console.WriteLine("EvenArrays   =  " + JsonConvert.SerializeObject(evenArrays));


            Console.ReadKey();
            Console.WriteLine("FizzBUzzElseIF");
            var fizzBUzzElseIF = new FizzBuzzElseIf();
            Console.Write("Number of Character =  ");
            int nx = Convert.ToInt32(Console.ReadLine());
            var BuzzResult = fizzBUzzElseIF.Get(nx);
            Console.WriteLine("BuzzResult   =  " + BuzzResult);


            Console.ReadKey();
            Console.WriteLine("RepeatingOfLetter");
            var repeatingOfLetters = new RepeatingOfLetter();
            Console.Write("Number of Character =  ");
            int n = Convert.ToInt32(Console.ReadLine());
            var Display = repeatingOfLetters.Get(n);
            Console.WriteLine("Bu"+Display+'p');


            Console.ReadKey();
            Console.WriteLine("ReturnFactorial");
            var returnFactorial = new ReturnFactorial();
            Console.Write("number  :  ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            var Result1 = returnFactorial.Get(num6);
            Console.WriteLine("ReturnFactorial = " + (Result1));

            Console.ReadKey();
            Console.WriteLine("POwer Of Numbers");
            var powerOfNumber = new PowerOfNumber();
            Console.Write("number  :  ");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.Write("exponent  :  ");
            long exponent = Convert.ToInt64(Console.ReadLine());
            var Result = powerOfNumber.Get(number,exponent);
            Console.WriteLine("Power of Number = " + (Result));

            Console.ReadKey();
            Console.WriteLine("AbsoluteSum");
            var absoluteSUm = new AbsoluteSum();
            int[] arr2 = { 7, -8, 9, -10 };
            var SumA = absoluteSUm.GetAbsSum(arr2);
            Console.WriteLine("Array = " + (SumA));

            Console.ReadKey();
            Console.WriteLine("Multiply by Length");
            var ppractice = new Practice();
            int[] arr = {5, 8, 3, 9 };
            var newArray = ppractice.GetArray(arr);
            Console.WriteLine("Array" + JsonConvert.SerializeObject(newArray));


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Profile");
            var profileService = new  ProfileService();
            Console.WriteLine("Birth Date");
            Console.Write("Day  :  ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month  :  ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year  :  ");
            int year = Convert.ToInt32(Console.ReadLine());
            var myBirthdate = profileService.GetBirthdate(day, month, year);
            Console.WriteLine(" Your  Date of Birth  is  " + myBirthdate);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Birth Place");
            Console.Write("Barangay :  ");
            string barangay = (Console.ReadLine());
            Console.Write("Town :  ");
            string town = (Console.ReadLine());
            Console.Write("Province  :  ");
            string province = (Console.ReadLine());
            var myBirthplace = profileService.GetBirthplace(barangay, town, province);
            Console.WriteLine(" Your  Place of Birth  is  " + myBirthplace);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Grade");
            var gradeService = new GradeService();
            var gradeAverageResult = new GradeAverageResultServices();
            Console.Write("English : ");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math : ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Science : ");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.Write("Computer : ");
            int computer = Convert.ToInt32(Console.ReadLine());

            var gradeaverage2 = gradeService.AverageOf2Subject(math, science);
            var gradeaverage3 = gradeService.AverageOf3Subject(math, science, english);
            var gradeaverage4 = gradeService.AverageOf4Subject(math,science,english,computer);

            var graderesult2 = gradeAverageResult.GetResult(gradeaverage2);
            var graderesult3 = gradeAverageResult.GetResult(gradeaverage3);
            var graderesult4 = gradeAverageResult.GetResult(gradeaverage4);
            
            Console.WriteLine();
            Console.WriteLine("Average of Two Numbers       :   " +gradeaverage2 );
            Console.WriteLine(graderesult2);
            Console.WriteLine("Average of Three Numbers    :   " +gradeaverage3 );
            Console.WriteLine(graderesult3);
            Console.WriteLine("Average of Four Numbers      :   " +gradeaverage4 );
            Console.WriteLine(graderesult4);
          
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("SUBTRACTION");
            var subtractionService = new SubtractionService();
            Console.Write("Number 1 :   ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 :   ");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3 :   ");
            int numb3= Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 4 :   ");
            int numb4 = Convert.ToInt32(Console.ReadLine());
            var difference2 = subtractionService.SubtractionOfTwoNumbers(numb1, numb2);
            var difference3 = subtractionService.SubtractionOfThreeNumbers(numb1,numb2, numb3);
            var difference4 = subtractionService.SubtractionOfFourNumbers(numb1, numb2, numb3, numb4);
            Console.WriteLine();
            Console.WriteLine("Difference of Two Numbers       :   " + difference2);
            Console.WriteLine("Difference of Three Numbers    :   " + difference3);
            Console.WriteLine("Difference of Four Numbers      :   " + difference4);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("AVERAGE");
            var averageService = new AverageService();
            Console.Write("Number 1 :   ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 :   ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3 :   ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 4 :   ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            var avearge2 = averageService.AverageOfTwoNumbers(num1, num2);
            var avearge3 = averageService.AverageOfThreeNumbers(num1, num2, num3);
            var avearge4 = averageService.AverageOfFourNumbers(num1, num2, num3, num4);
            Console.WriteLine();
            Console.WriteLine("Average of Two Numbers       :   " + avearge2);
            Console.WriteLine("Average of Three Numbers     :   " +avearge3);
            Console.WriteLine("Average of Four Numbers      :   " + avearge4);


            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("ADDITION");
            var additionService = new AdditionService();
            Console.Write("Number 1 :   ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2 :   ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3 :   ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 4 :   ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            var sum2 = additionService.AddTwoNumbers(number1, number2);
            var sum3 = additionService.AddThreeNumbers(number1,number2, number3);
            var sum4 = additionService.AddFourNumbers(number1, number2, number3,number4);
            Console.WriteLine();
            Console.WriteLine("Sum of Two Numbers       :   " + sum2);
            Console.WriteLine("Sum of Three Numbers     :   " + sum3);
            Console.WriteLine("Sum of Four Numbers      :   " + sum4);
        }
    }
}
