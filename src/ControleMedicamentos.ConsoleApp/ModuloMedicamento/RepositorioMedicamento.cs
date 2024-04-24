using ControleMedicamentos.ConsoleApp.Compartilhado;
using System;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class RepositorioMedicamento
    {
        private Medicamento[] medicamentos = new Medicamento[100];

        public void CadastrarMedicamento(Medicamento novoMedicamento)
        {
            novoMedicamento.id = GeradorId.GerarIdMedicament();

            RegistrarItem(novoMedicamento);
        }
        private void RegistrarItem(Medicamento medicamento)
        {
            for (int i = 0; i < medicamentos.Length; i++)
            {
                if (medicamentos[i] != null)
                    continue;

                else
                {
                    medicamentos[i] = medicamento;
                    break;
                }
            }
        }
    }
}
