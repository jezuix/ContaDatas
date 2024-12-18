using BrazilHolidays.Net;

namespace ContaDatas.Utils
{
    public static class SomaDiasUteis
    {
        public static DateTime Somar(DateTime dataInicial, int quantidadeDiasSomados)
        {
            if (quantidadeDiasSomados < 0)
                throw new ArgumentException("Os dias somados não podem ser negativos.", nameof(quantidadeDiasSomados));

            var dataAtual = dataInicial;

            while (quantidadeDiasSomados > 0)
            {
                dataAtual = dataAtual.AddDays(1);

                // Verificar se é dia útil
                if (dataAtual.DayOfWeek != DayOfWeek.Saturday &&
                    dataAtual.DayOfWeek != DayOfWeek.Sunday &&
                    !dataAtual.Date.IsHoliday())
                {
                    quantidadeDiasSomados--;
                }
            }

            return dataAtual;
        }
    }
}
