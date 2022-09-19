using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace SistemaDePedidos
{
    class Funcionario
    {
        private string Nome { get; set; }
        private int Matricula { get; set; }        

        public void ValidarFuncionario()
        {
            Loja linkClassLoja = new();                        

            string[] FuncNome = new string[] { "JARDEL", "LUCAS", "RODNEY", "ROBERTO" };
            int[] FuncMat = new int[] { 4718, 3079, 2202, 9894 };

            // retirar espaços:
            //string.TrimEnd() -> tira espaços no final. 
            //string.TrimStar() -> tira espaços no início.
            //string.Trim() -> tira espaços no início e no final.
            //string.Replace(" ", "") -> tira espaços no início, meio e no final.
            while (true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("            Faça seu login!        ");
                Console.WriteLine("----------------------------------------");
                Console.Write("INFORME SEU NOME: ");
                string Nomes = Console.ReadLine().ToUpper().Replace(" ", "");
                Console.Write($"{Nomes}, INFORME SUA MATRÍCULA: ");
                int Mat = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------");
                if (Nomes != "JARDEL" || Mat != 4718)
                {                    
                    Console.Clear();
                    Console.WriteLine("Login inválido");                  


                    if (Nomes != "LUCAS" || Mat != 3079)
                    {                        
                        Console.Clear();
                        Console.WriteLine("Login inválido");                        
                    }
                    else
                    {
                        Console.WriteLine("Login efetuado com sucesso");
                        Console.Clear();
                        linkClassLoja.Menu();
                        break;
                    }
                    if (Nomes != "RODNEY" || Mat != 2202)
                    {                        
                        Console.Clear();
                        Console.WriteLine("Login inválido");                        
                    }
                    else
                    {
                        Console.WriteLine("Login efetuado com sucesso");
                        Console.Clear();
                        linkClassLoja.Menu();
                        break;
                    }
                    if (Nomes != "ROBERTO" || Mat != 9894)
                    {                        
                        Console.Clear();
                        Console.WriteLine("Login inválido");                        
                    }
                    else
                    {
                        Console.WriteLine("Login efetuado com sucesso");
                        Console.Clear();
                        linkClassLoja.Menu();
                        break;
                    }                   
                }
                else
                {
                    Console.WriteLine("Login efetuado com sucesso");
                    Console.Clear();
                    linkClassLoja.Menu();
                    break;
                }               
            }                     
               
        }
    }
}