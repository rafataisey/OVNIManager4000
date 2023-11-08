using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOVNI
{
    public class OVNI
    {
        /*
         * ATRIBUTOS PRIVADOS:
         */ 

        // Ligado ou Desligado
        private bool _situacao;

        private readonly int _maxTripulantes;
        private int _maxAbduzidos;

        private int _qtdTripulantes;
        private int _qtdAbduzidos;

        private string _planetaOrigem;
        private string _planetaAtual;
        private static readonly string[] _planetasValidos = { "Terra", "Gallifrey", 
            "Krypton", "Pandora", "Miller" };

        /* 
         * Propriedades:
         */
        public bool Situacao { get { return _situacao; } }

        // Propriedade estática poderá ser utilizada sem necessidade de instanciação:
        public static string[] PlanetasValidos { 
            get { 
                Array.Sort(_planetasValidos); 
                return _planetasValidos; 
            } 
        }
        public int QtdAbduzidos { get { return _qtdAbduzidos;} }
        public int QtdTripulantes { get { return _qtdTripulantes;} }

        public string PlanetaAtual { get { return _planetaAtual;} }

        

        public OVNI(int maxTripulantes, int maxAbduzidos, string planetaOrigem) 
        {
            // O construtor irá apenas definir a capacidade máxima do veículo:
            _maxTripulantes = maxTripulantes;
            _maxAbduzidos = maxAbduzidos;
            _planetaOrigem = planetaOrigem;
            
            // Iniciar os valores padrões:
            _situacao = false;
            _qtdAbduzidos = 0;
            _qtdTripulantes = 1; // O veículo deve possuir ao menos 1 tripulante.
            _planetaAtual = planetaOrigem;
        }

        public bool Ligar()
        {
            // Ligar apenas se o veículo estiver desligado:
            if (_situacao == false)
            {
                _situacao = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Desligar()
        {
            // Desligar apenas se o veículo estiver ligado:
            if (_situacao == true)
            {
                _situacao = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AdicionarTripulante()
        {
            // Retornar true apenas se o novo tripulante não execeder _maxTripulantes:
            if((_qtdTripulantes+1) > _maxTripulantes)
            {
                return false;
            }
            else
            {
                _qtdTripulantes++;
                return true;
            }
        }
        public bool RemoverTripulante()
        {
            // Retornar true apenas se o número de tripulantes não for ficar < 1
            if ((_qtdTripulantes - 1) == 0)
            {
                return false;
            }
            else
            {
                _qtdTripulantes--;
                return true;
            }
        }

        public bool Abduzir()
        {
            // Retornar true apenas se o novo abduzido não exceder _maxAbduzidos:
            if((_qtdAbduzidos+1) > _maxAbduzidos)
            {
                return false;
            }
            else
            {
                _qtdAbduzidos++;
                return true;
            }
        }
        public bool Desabduzir()
        {
            // Retornar true apenas se houver alguem para "desabduzir":
            if ((_qtdAbduzidos - 1) == -1)
            {
                return false;
            }
            else
            {
                _qtdAbduzidos--;
                return true;
            }
        }

        public bool MudarPlaneta(string novoPlaneta)
        {
            // Verificar se o OVNI pode mudar para um planeta válido:
            if (_planetasValidos.Contains(novoPlaneta) && novoPlaneta != _planetaAtual)
            {
                _planetaAtual = novoPlaneta;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RetornarAoPlanetaDeOrigem()
        {
            // Retornar true apenas se o OVNI não estiver no planeta de origem:
            if(_planetaAtual == _planetaOrigem)
            {
                return false;
            }
            else
            {
                _planetaAtual = _planetaOrigem;
                return true;
            }
        }

    }
}
