namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    public static class GeradorId
    {
        private static int idMedicamento = 0;
        private static int idPaciente = 0;
        private static int idRequisicao = 0;

        public static int GerarIdMedicament()
        {
            return ++idMedicamento;
        }

        public static int GerarIdPacciente()
        {
            return ++idPaciente;
        }

        public static int GerarIdRequisecao()
        {
            return ++idRequisicao;
        }

    }
}

