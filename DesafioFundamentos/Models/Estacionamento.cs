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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            bool placaCorreta = false;
            string placa = "";
            while (!placaCorreta)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar, lembrando que deve ter 7 digitos e seguir o formato: ABC1D23");
                placa = Console.ReadLine();
                for (int i = 0; i < placa.Length; i++)
                {
                    if (placa.Length != 7)
                    {
                        Console.WriteLine($"Erro, a placa deve ter 7 digitos");
                        break;
                    }
                    else if ((i <= 2 && char.IsLetter(placa, i)) || (i == 4 && char.IsLetter(placa, i)))
                    {
                        placaCorreta = true;
                    }
                    else if ((i == 3 && char.IsDigit(placa, i)) || (i > 4 && char.IsDigit(placa, i)))
                    {
                        placaCorreta = true;
                    }
                    else
                    {
                        placaCorreta = false;
                    }
                    if (!placaCorreta)
                    {
                        Console.WriteLine($"Erro, a placa deve seguir o formato: ABC1D23");
                        break;
                    }
                }
            }
            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            bool carroExiste = false;
            while (!carroExiste)
            {
                string placa = "";
                placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    carroExiste = true;
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    int horas = 0;
                    decimal valorTotal = 0;
                    string val = Console.ReadLine();
                    while (!Int32.TryParse(val, out horas))
                    {
                        System.Console.WriteLine("Erro, a quantidade de horas tem que ser digitada com algorismos númericos");
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        val = Console.ReadLine();
                    }
                    valorTotal = precoInicial + precoPorHora * horas;

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string i in veiculos)
                {
                    System.Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
