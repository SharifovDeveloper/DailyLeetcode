namespace Algorithms
{
    public class DailyLeetcode
    {
        public int SumOfEncryptedInt(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                int maxDigit = 0;
                int number = num;
                while (number > 0)
                {
                    int digit = number % 10;
                    maxDigit = Math.Max(maxDigit, digit);
                    number /= 10;
                }
                int encryptedNumber = int.Parse(new string((char)(maxDigit + '0'), num.ToString().Length));
                sum += encryptedNumber;
            }
            return sum;
        }
    }
}
