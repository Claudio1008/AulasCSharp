//se o aluno tiver mais que 3 faltas
//Rodo

//se a nota do aluno fo menor que 60
//Rodo tambem

#region
/*CODIGO DE FALTAS E NOTAS (APROVADO / REPROVADO)
int nota = 60;
int faltas = 3;
string opcao;
while (true)
{

    Console.WriteLine("informe a nota");
    nota = int.Parse(Console.ReadLine());

    Console.WriteLine("informe as faltas");
    faltas = int.Parse(Console.ReadLine());

    if (nota >= 60 && faltas <= 3)
    {
        Console.WriteLine($"A nota do aluno é {nota}, e suas faltas são {faltas} ele está Aluno Aprovado");
    }
    else { Console.WriteLine($"A nota do aluno é {nota}, e suas faltas são {faltas} ele está Aluno Reprovado"); }

    Console.WriteLine("deseja continuar ? s/n");
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        break;
    }
    else { Console.Clear(); }
}
*/
#endregion

//FOR
/*
int contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada");
tabuada = Convert.ToInt32(Console.ReadLine());

for(contador = 0; contador < 11; contador++)
{
    Console.WriteLine(
        $"{tabuada} X {contador} = {tabuada * contador}");
}
*/

//WHILE
/*int contador = 0;

while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do{

    Console.WriteLine(contador);
    contador++;

} while (contador < 10);
*/

//FOREACH
/*string[] nomes = { "abacaxi", "maçã", "kiwi" };
int[] numeros = { 0, 1, 2, 3, 4, 5 };

foreach(int i in numeros)
{
    Console.WriteLine(i);
}
foreach(string i in nomes)
{
    Console.WriteLine(i);
}

Console.ReadKey();
*/

/*
int idadeAluno;

bool MaiorDeIdade(int idade)
{

    if (idade >= 18)
    {
        return true;
    }else
    {
        return false;
    }
}

void MaiorDeIdade2(int idade)
{

    if (idade >= 18)
    {
        Console.WriteLine("Aluno maior de idade");
    }
    else
    {
        Console.WriteLine("Aluno menor de idade");
    }
}

MaiorDeIdade2(15);



Console.WriteLine("Informe sua idade");
idadeAluno = Convert.ToInt32(Console.ReadLine());

if(MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de idade");
}
else { Console.WriteLine("Aluno menor de idade"); }

MaiorDeIdade(20);
*/

//função para somar do tipo void
//função que retorne a multiplicação resultado int

void Somar(int numero1, int numero2)
{
    Console.WriteLine(
        $"soma dos valores: {numero1 + numero2}");
}

Somar(5, 10);

int Multiplicacao(int num1, int num2)
{
    return num1 * num2;
}

int resultado = Multiplicacao(3, 5);
resultado = Multiplicacao(40, 50);
Console.WriteLine(resultado);