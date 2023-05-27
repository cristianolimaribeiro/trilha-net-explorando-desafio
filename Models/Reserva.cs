namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(int hospedes)
        {

            if (hospedes <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            return Hospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = (valor * 0.1M);

            if (DiasReservados >= 10)
            {
                
                valor = valor - desconto;
            }

            return valor;
        }
    }
}