using System;

namespace lab2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
		Să se scrie un program care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatura
		*/
		
		Console.WriteLine("Introduceti n= ");
		int n ;
		n = int.Parse(Console.ReadLine());
		
		int[] array=new int[n];
		
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("Introduceti numarul de pe pozitia " + i);
			array[i] = int.Parse(Console.ReadLine());
		}
		
		int sumaNumerePare = 0;
		int nrNumerePare = 0;
		
		for(int i = 0;i<n;i++)
		{
			if(array[i] % 2 == 0)
			{
				sumaNumerePare = sumaNumerePare + array[i];
				nrNumerePare++;
			}
		}
		
		decimal mediaAritmetica = sumaNumerePare / nrNumerePare;
		
		Console.WriteLine("Media aritmetica a numerelor pare din sirul introdus este: " + mediaAritmetica);
        }
    }
}
