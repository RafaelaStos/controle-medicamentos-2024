using ControleMedicamentos.ConsoleApp.ModuloMedicamento;

namespace ControleMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaMedicamento telaMedicamento = new TelaMedicamento();

            telaMedicamento.CadastrarMedicamento();
        }
    }
}
