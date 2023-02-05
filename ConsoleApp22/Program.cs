internal class Program
{
    private static void Main(string[] args)
    {
        int[] chisla = { 1, 2, 3, 1, 1, 2, 3, 4, 4 };
        Array.Sort(chisla);
        // я объявил массив и отсортировал его
        int majPovtor = 0;
        int maj_digit = 0;
        int majPovtor1 = 0;
        int maj_current = chisla[0];

        foreach (int j in chisla)
        {
            if (j == maj_current)
            {
                majPovtor1++;
            }
            // если j равно текущему мажоритарному числу, то мы увеличиваем число повторов данного числа на 1
            else
            {
                majPovtor1 = 1;
                maj_current = j;
            }
            // если появляется новое число в массиве, то мы объявляем новое мажоритарное число и увеличиваем число его повторов на 1 
            if (majPovtor1 > majPovtor)
            {
                majPovtor = majPovtor1;
                maj_digit = j;
            }
            // если число повторов мажоритарного числа больше, чем число повторов предыдущего, то мажоритарное число становится равным текущему элементу массива

        }
        Console.WriteLine($"Мажоритарное число - " + maj_digit);
    }
}
