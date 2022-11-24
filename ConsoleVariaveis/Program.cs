using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVariaveis
{
    class Program
    {
        enum Notas
        {
            Minima,
            Media,
            Maxima
        }

        enum SatisfacaoCliente
        {
            TotalmenteInsatisfeito = 1,
            Insatisfeito = 2,
            Imparcial = 3,
            Satisfeito = 4,
            TotalmenteSatisfeito = 5
        }

        struct Entidade
        {
            public string Nome;
            public int Idade;
            public double Peso;
        }
        static void Main(string[] args)
        {
            #region Variaveis numericas            
            // variaveis integral assinado - aceitam números negativos
            sbyte num1 = 10; // 8 bits de -128 a 127
            short num2 = 20; // 16 bits de -32.768 a 32.767
            int num3 = 30; // 32 bits de -2.147.483.648 a 2.147.483.647
            long num4 = 40; // 64 bits de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            // variaveis integral sem sinal - não suportam números negativos 
            byte num5 = 1; // 8 bits de 0 a 255
            ushort num6 = 2; // 16 bits de 0 a 65.535
            uint num7 = 3; // 32 bits de 0 a 4.294.967.295
            ulong num8 = 4; //64 bits + de 18 quintilhões

            num1 = 125;

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            Console.WriteLine("num3: " + num3);
            Console.WriteLine("num4: " + num4);
            Console.WriteLine("num5: " + num5);
            Console.WriteLine("num6: " + num6);
            Console.WriteLine("num7: " + num7);
            Console.WriteLine("num8: " + num8);
           
            #endregion

            #region Variaveis numericas reais
            float Aliquota = 1.99f;//4 bytes - 32 bits
            double Preco = 99.99;//8 bytes - 64 bits
            decimal Salario = 10000.99m;//16 btyes - 128 bits

            Console.WriteLine(" ");
            Console.WriteLine(" ******** numeros reais ******** ");
            Console.WriteLine(" ");
            Console.WriteLine("Aliquota: " + Aliquota);
            Console.WriteLine("Preco: " + Preco);
            Console.WriteLine("Salario: " + Salario);
            
            #endregion

            #region Caracteres
            char Letra = 'J';

            // \u -> significa inclusão de codigo UTF-16
            // \n -> quebra de linha
            // \0 -> representa o caracter nulo
            // \\ -> imprime uma barra invertida

            char LetraCodificada_a = '\u0061'; // codigo hexa do caracter "a"
            char LetraCodificada_A = '\u0041'; // codigo hexa do caracter "A"

            Console.WriteLine(" ");
            Console.WriteLine(" ******** caracteres ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("Letra: " + Letra);
            Console.WriteLine("LetraCodificada_a: " + LetraCodificada_a);
            Console.WriteLine("LetraCodificada_A: " + LetraCodificada_A);
            #endregion

            #region Variaveis boolean
            bool Verdadeiro = true;

            Console.WriteLine(" ");
            Console.WriteLine(" ******** variável boleana ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("Verdadeiro: " + Verdadeiro);
            #endregion

            #region Variaveis Tipos Strings
            // Variavel string é por referencia
            string Nome = "Meu nome é Jefferson";
            string strNula = null;

            string Original = "Original";
            string CopiaBarata = Original;

            Console.WriteLine(" ");
            Console.WriteLine(" ******** Variaveis Tipos Strings  ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("strNula: " + strNula);

            Console.WriteLine("Original: " + Original);
            Console.WriteLine("CopiaBarata: " + CopiaBarata);
            CopiaBarata = "Falsificada";
            Console.WriteLine("Original: " + Original);
            Console.WriteLine("CopiaBarata: " + CopiaBarata);

            string Ignorar = @"Jefferson \n Rain";
            Console.WriteLine("Testando arroba como ignore dos scapes: " + Ignorar);
            #endregion

            #region Tipo var
            var Qualquer = 120.99;
            var Variante = "O brasil vai jogar na copa de 2022";

            Console.WriteLine(" ");
            Console.WriteLine(" ******** Variaveis Tipos VAR  ******** ");
            Console.WriteLine(" ");
            Console.WriteLine("Voce declara a variavel e o compilador defini o tipo pelo valor que é atribuido.");
            
            Console.WriteLine("Qualquer: " + Qualquer.GetType().Name + " " + Qualquer);
            Console.WriteLine("Variante: " + Variante.GetType().Name + " " + Variante);
            #endregion

            #region Tipo Object
            // Tipo object é a base para todos os tipos e consegue armazenar qualquer tipo de dados
            object objNumero = 100;
            object objTexto = "Nome completo";
            object objQualquerTipo = 99.99;
            objQualquerTipo = "Outro tipo string";

            Console.WriteLine(" ");
            Console.WriteLine(" ******** Tipo Object ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("objNumero: " + objNumero);
            Console.WriteLine("objTexto: " + objTexto);
            Console.WriteLine("objQualquerTipo: " + objQualquerTipo);
            #endregion

            #region Tipos ENums - Enumerados
            Notas nota = Notas.Maxima;
            SatisfacaoCliente pesquisa = SatisfacaoCliente.Satisfeito;

            Console.WriteLine(" ");
            Console.WriteLine(" ******** Tipo Enum ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("nota: " + nota);
            Console.WriteLine("pesquisa: " + pesquisa);
            #endregion

            #region Estruturas Struct
            Entidade pessoa = new Entidade();
            pessoa.Nome = "jefferson";
            pessoa.Peso = 131.7;
            pessoa.Idade = 41;

            Console.WriteLine(" ");
            Console.WriteLine(" ******** Tipo Struct ******** ");
            Console.WriteLine(" ");

            Console.WriteLine("Struct pessoa: " + pessoa);

            objQualquerTipo = pessoa;
            Console.WriteLine("objQualquerTipo: " + objQualquerTipo);

            // outra forma de instanciar uma struct
            Entidade pessoa2 = new Entidade() { Nome = "Jefferson", Idade = 41, Peso = 120.99};
            Console.WriteLine("pessoa2: " + pessoa2.Nome + " - idade: " + pessoa2.Idade + " - peso: " + pessoa2.Peso);
            #endregion

            Console.ReadKey();
        }
    }
}
