using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимально возможное число(от 0 до 1000) и значение количества выводимых чисел(от 0 до 100) через пробел");
            string strMaxN = Console.ReadLine();
            string[] strMaxNArr = strMaxN.Split(' ');
            int max;
            int n;

            if(strMaxNArr.Length < 2)
            {
                Console.WriteLine("Было введено недопустимое значение, попробуйте снова");
                return;
            }

            if (!Int32.TryParse(strMaxNArr[0], out max) || !Int32.TryParse(strMaxNArr[1], out n))
            {
                Console.WriteLine("Было введено недопустимое значение, попробуйте снова");
                return;
            }
            
            if(max > 1000 || max < 0 || n > 100 || n < 0)
            {
                Console.WriteLine("Вы вышли за допустимый диапазон значений, попробуйте снова");
                return;
            }

            Random rnd = new Random();
            int [] rndValues = new int[n];
            string strOfRndValues = "";
            for (int i = 0; i < n; i++)
            {
                rndValues[i] = rnd.Next(-max, max);
                strOfRndValues += rndValues[i].ToString() + " ";
            }

            Console.WriteLine(strOfRndValues);

            int sum = 0;
            string strOfSum = "";
            for(int i = 0; i < n; i++)
            {
                sum += Math.Abs(rndValues[i]);
                if (rndValues[i] >= 0 && i == 0)
                    strOfSum += rndValues[i];
                if(rndValues[i] >= 0 && i != 0)
                    strOfSum += "+" + rndValues[i];
                if(rndValues[i] < 0)
                    strOfSum += "-" + "(" +rndValues[i] + ")";
            }

            Console.WriteLine(strOfSum + "=" + sum);
        }
    }
}
