using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;

namespace _240401_01.Views
{
    public class OrderView
    {

        public OrderView()
        {
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU DE PEDIDOS");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Pedido");
                Console.WriteLine("2 - Pesquisar Pedido");
                Console.WriteLine("3 - Listar Pedido");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3: 
                        break;
                        default: 
                            Console.WriteLine("Opção inválida.");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida.");
                    menu = -1;
                }                
            }while(aux);
        }

    }   
}