namespace beecrowd_2242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string risada = Console.ReadLine();
            int i = 0, j = risada.Length - 1;
            bool engracada = true;

            while (i < j)
            {
                while (i < risada.Length && !IsVowel(risada[i]))
                {
                    i++;
                }

                while (j >= 0 && !IsVowel(risada[j]))
                {
                    j--;
                }

                if (i < j && risada[i] != risada[j])
                {
                    engracada = false;
                    break;
                }

                i++;
                j--;
            }

            if (engracada)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

        static bool IsVowel(char c)
        {
            return c == 'a' ||  c == 'e' ||  c == 'i' ||  c == 'o' ||  c == 'u';
        }
    }
}
