
namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class Medicamento
    {
        public int id;
        public string nameMedicamento;
        public DateTime validade;
        public int qtdMdicamento;

        public Medicamento(string nameMedicamento, DateTime validade, int qtdMdicamento)
        {
            this.nameMedicamento = nameMedicamento;
            this.validade = validade;
            this.qtdMdicamento = qtdMdicamento;
        }
    }
}
