using System;
using System.Linq;
namespace Open_Lab_04._06
{
    
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {           
            for (int i = 0; i < numbers.Length; i++)
            {
                int a = numbers[i] % 2;
                int b = numbers[i];
                if (a == 1)
                {
                    int indexToRemove = i;
                    numbers = numbers.Where((source, index) => index != indexToRemove).ToArray();
                 }                                                            
            }

            return numbers;

        }
    }
}
