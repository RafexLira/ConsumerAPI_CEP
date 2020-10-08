using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerAPI
{
    class Program
    {       //Estamos usando uma tarefa asssincrona com async task no método Main
        static async Task Main(string[] args)
        {
            string CepInformado;          

            try
            {                   
                var CepClient = RestService.For<ICepAPIService>("http://viacep.com.br");

                Console.WriteLine("ISTO APENAS É UM TESTE\n");

                Console.WriteLine("Informe o CEP que deseja consultar: ");
                CepInformado = Console.ReadLine();

                var Address = await CepClient.GetAddressAsync(CepInformado);

                Console.WriteLine("ISTO APENAS É UM TESTE \n");
                Console.WriteLine("\nLogradouro: {0}\nBairro: {1}\nCidade: {2}",Address.Logradouro,Address.Bairro, Address.Localidade);

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("ISTO APENAS É UM TESTE \n");
                Console.WriteLine("Erro ao consultar CEP, Verifique os campos e tente novamente "+ e.Message);
            }

        }
    }
}
