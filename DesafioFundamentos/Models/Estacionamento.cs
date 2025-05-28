namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            Console.ResetColor();

            string placa = Console.ReadLine();
            veiculos.Add(placa);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
            Console.ResetColor();
        }

        public void RemoverVeiculo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.ResetColor();

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                Console.ResetColor();

                int horas;
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido. Digite um número inteiro válido para as horas:");
                    Console.ResetColor();
                }

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.ResetColor();
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Os veículos estacionados são:");
                Console.ResetColor();

                foreach (var veiculo in veiculos)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(veiculo);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há veículos estacionados.");
                Console.ResetColor();
            }
        }
    }
}