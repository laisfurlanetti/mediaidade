using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaidade
{
    class Program
    {
        static void Main(string[] args)
        {
            string parar;
            int idade;

            List<int> listaidade = new List<int>();

            do
            {
                Console.Write("Informe a sua idade: ");
                parar = Console.ReadLine();
                if (parar == "sair")
                    break;
                else
                {
                    idade = Convert.ToInt32(parar);
                    listaidade.Add(idade);
                }
                
            }
            while (parar != "sair");

            double media = listaidade.Average();

            Console.Clear();

            Idade(media);

            Console.ReadLine();

        }
        public static void Idade(double media)
        {
            if (media >= 0 && media <= 25)
                Console.WriteLine("A turma é Jovem");

            if (media >= 26 && media <= 60)
                Console.WriteLine("A turma é Adulta");

            if (media > 60)
                Console.WriteLine("A turma é Idosa");
        }
    }
}