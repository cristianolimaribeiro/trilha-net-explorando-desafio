using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria a lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
// Cria os modelos de hóspedes e cadastra na lista de hóspedes

Console.WriteLine("Digite seu Nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu Sobrenome: ");
string sobrenome = Console.ReadLine();

Pessoa hospede = new Pessoa(nome, sobrenome);
hospedes.Add(hospede);

// Cria a suíte

string _tipoSuite = "";
int _capacidade = 0;
int _valorDiaria = 0;

Console.WriteLine("Escolha o tipo da Suite \n P - Premium \n M - Master \n S - Simples");

_tipoSuite = Console.ReadLine().ToUpper();

               switch (_tipoSuite)
                {
                    case "P":
                        _tipoSuite = "Premium";
                        _capacidade = 5;
                        _valorDiaria = 150;

                        break;
                    case "M":
                        _tipoSuite = "Master";
                        _capacidade = 3;
                        _valorDiaria = 120;

                        break;
                    case "S":
                        _tipoSuite = "Simples";
                        _capacidade = 2;
                        _valorDiaria = 80;

                        break;
                    default:
                        if (_tipoSuite == "")
                        {
                            Console.WriteLine("Você precisa escolher o tipo da suite que deseja");
                        }
                        break;

                }

Console.WriteLine($"Você escolheu a Suite {_tipoSuite} e o valor da diária é {_valorDiaria}");
Suite suite = new Suite(tipoSuite: _tipoSuite, capacidade: _capacidade, valorDiaria: _valorDiaria);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Quantos dia ficará hospedado? ");
int _diasReservados = Convert.ToInt32(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados: _diasReservados);

Console.WriteLine("Quantas pessoas se hospedaram na suite alem de você? ");
int quantidadeDeHospedes = Convert.ToInt32(Console.ReadLine());

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(quantidadeDeHospedes);

// Exibe a quantidade de hóspedes e o valor da diária

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
