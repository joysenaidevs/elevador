using System;

namespace elevador.classe
{
    public class Elevador
    {
        public int andarAtual = 0;
        public int AndarAtual{
            get {return andarAtual;}
            set {andarAtual = value;}
        }

        public int totalDeAndares;
        public int TotalDeAndares{
            get {return totalDeAndares;}
            set {totalDeAndares = value;}
        }
        public int capacidadeDoElevador;
        public int CapacidadeDoElevador{
            get {return capacidadeDoElevador;}
            set {capacidadeDoElevador = value;}
        }
        public int pessoasPresentes;
        public int PessoasPresentes{
            get {return pessoasPresentes;}
            set {pessoasPresentes = value;}
        }
        public int ultimoAndar = 9;

        //Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
        public string Inicializar(){
            totalDeAndares = 9;
            capacidadeDoElevador = 10;
            return "Elevador inicializado";
        }

        public string Entrar(){
            pessoasPresentes = 10;

            if (capacidadeDoElevador >=11){
                Console.WriteLine("Não há mais espaço no elevador");
            }else{
                Console.WriteLine("Ainda há espaço");
            }

            return "Capacidade do elevador verificada";
           
        }

        // Sair : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
        public string Sair(){
            if (pessoasPresentes >=11)
            {
                Console.WriteLine("Você será removido");
            }else{
                Console.WriteLine("Você pode entrar no elevador");
            }
            return "";

        }

        // Subir : para subir um andar (não deve subir se já estiver no último andar);
        public string Subir(){
            for (var i = 0; i < 9; i++)
            {
                Console.WriteLine("Você está no ultimo andar não é possivel subir mais");
            }
                Console.WriteLine("Voce está subindo para o andar desejado");
            return "";
        }

        // Descer : para descer um andar (não deve descer se já estiver no térreo); 
        //Encapsular todos os atributos da classe (criar os métodos set e get)
        public string Descer(){
            return "";
        }
    }
}