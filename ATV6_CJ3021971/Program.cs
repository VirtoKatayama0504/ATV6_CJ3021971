namespace ATV6_CJ3021971
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            int nx = 1;
            Console.WriteLine("Digite um numero inteiro");
            int nz = int.Parse(Console.ReadLine());
            while (nx <= nz)
            {
                nx++;
                Console.WriteLine(nx);
                
            }

            Console.WriteLine("Exercicio 2");
            int n1 = 0;
            Console.WriteLine("Digite um numero inteiro");
            int n2 = int.Parse(Console.ReadLine());
            while (n1 < n2)
            {
                n1++;
                if (n1 % 2 == 0)
                {
                    
                    Console.WriteLine(n1);
                }
            }

            Console.WriteLine("Exercicio 3");
            int n3 = 1000;
            Console.WriteLine("Digite um numero menor que 1000");
            int n4 = int.Parse(Console.ReadLine());
            if (n4 < n3)
            {
                while (n4 > 0)
                {
                    n4--;
                    if(n4 % 2 == 0)
                    {
                        Console.WriteLine(n4);
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção INvalida");
            }

            Console.WriteLine("Exercicio 4");
            int rr; int ww = 0;
            while (ww < 200)
            {
                Console.WriteLine("Digite uma sequnecia de numeros inteiros ");
                rr = int.Parse(Console.ReadLine());
                if (rr > 0)
                {
                    ww += rr;
                }

                Console.WriteLine(ww);
            }

            Console.WriteLine("Exercicio5");
            int n5, n6 = 1;
            Console.WriteLine("Digite um numero");
            n5 = int.Parse(Console.ReadLine());
            while(n6<= n5)
            {
                n6++;
                if(n5 % n6 == 0)
                {
                    Console.WriteLine(n6);  
                }

            }
        }
    }
}
