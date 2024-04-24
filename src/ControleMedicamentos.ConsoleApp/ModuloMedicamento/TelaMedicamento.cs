using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class TelaMedicamento
    {
        public RepositorioMedicamento repositorio = new RepositorioMedicamento();



        public void CadastrarMedicamento()
        {
            Console.Clear();

            Cabeçario();

            Console.WriteLine();

            Console.WriteLine("Cadastrando Medicamento...");

            Console.WriteLine();

            Console.WriteLine("Digite nome do Mendicamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a data de validade do Mendicamento: ");
            DateTime validade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a quantidada de Mendicamento: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            Medicamento medicamento = new Medicamento(nome, validade, qtd) ;
            repositorio.CadastrarMedicamento(medicamento);
        }

        static void Cabeçario() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|         Gestão de Medicamento        |");
            Console.WriteLine("----------------------------------------");
        }
    }
}
