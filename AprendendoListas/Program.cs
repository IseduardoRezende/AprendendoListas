using System;
using System.Collections.Generic; //-> Esse modulo trás coleções e dentro destas temos as Listas;
using System.Linq;   // -> Modulo que apenas o C# tem, Trás várias funções de manipulações de dados;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas  //Listas: Array ilimitado, se ajusta podendo adicionar e retirar itens a qualquer momento;
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq Trabalham muito bem com Listas;
            //Dentro do Linq podemos ter: 

            //Filtraagem
            //Remover
            //Busca

            //Listas é um tipo de coleção do System.Collections.Generic, assim como:
            //Dicionários;
            //Sets;
            //HashTables

            //Tipos primitivos = var, char, int, string, float... Precisa do "new";
            //Lista é um tipon de dados complexo porém dentro de uma coleção;

            //Você trabalha com Arrays apenas quando sabe a quantidade exata de itens que vai ter;
            //Listas se utiliza quando você não sabe a quantidade exata de cada item que vão ser armazenados;

            //string nome; = null, se não inicializar sua variável ela tem valor nulo;

            List<string> clientes = new List<string>();
            clientes.Add("Eduardo");
            clientes.Add("Rezende");  // Se por acaso eu não soubesse o indice do item, o Predicato do modulo Linq faz esse favor, podento excluir os dados;   
            string nome = "Lívia";
            clientes.Add(nome);
            clientes.Add("Joel");
            clientes.Add("Raquel");
            
            clientes[0] = "Eduardo R"; //Editando item da Lista;
            
            foreach (string cliente in clientes) //Antes...
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("===================");
            Console.WriteLine("Efetuando busca....");

            //Se você aplica uma condição nula = null ele retorna nada;
            //Find retorna apenas o primeiro elemento encontrado da Lista;
            //string busca = clientes.Find(cliente => cliente.Length <= 5);   //Encontrar um item de sua Lista; //Funciona igual o RemoveAll;

            //Retorna multiplos elementos, utiliza-se outro método o FindAll;
            List<string> filtrada = clientes.FindAll(cliente => cliente.Length >= 5);

            Console.WriteLine("Busca feita:");

            foreach (string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }

            /*if (busca == null)
            {
                Console.WriteLine("Não encontrado.");
            }
            
            Console.WriteLine(busca); */   

            //Retorna atráves do int quant = * ....  //RemoveAll é mais pesado; 
            //clientes.RemoveAll(cliente => cliente == "Rezende");  //O Predicato é uma frase onde o C# testa essa frase para cada elemento dentro da Lista, ele pega o resultato e se o resultado for verdadeiro o C# faz um teste; 
            
            //Mais leve, Recomendado se souber o indice.
            clientes.RemoveAt(1);  //Remove itens da sua List;

            Console.WriteLine("=====================");
            
            foreach (string cliente in clientes)  //Depois do RemoveAt ou RemoveAll...
            {
                Console.WriteLine(cliente);
            }
            
            Console.ReadLine();
        }
    }
}
