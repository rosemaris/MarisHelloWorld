namespace Computations.Challenges.Level1_VeryEasy
{
    /*
            === Return the Sum of Two Numbers===

            Create a function that takes two numbers as arguments and returns their sum.

            Examples
            Sum(3, 2) ➞ 5
            Sum(-3, -6) ➞ -9
            Sum(7, 3) ➞ 10

            Notes
            Don't forget to return the result
     */
    public interface IAddingTwoNumbers
    {
        int Get(int a, int b);
    }

    public class AddingTwoNumbers : IAddingTwoNumbers
    {
        public int Get(int a, int b)
        {
            var sum = a + b;
            return sum;
        }
    }
}
