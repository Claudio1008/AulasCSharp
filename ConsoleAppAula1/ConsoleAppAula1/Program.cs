/*IF IDADE
 * //int idade;
//Console.WriteLine("digite sua idade");
//idade = Convert.ToInt32(
//    Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine($"sua idade é {idade},voce é maior de idade");
//}
//else
//{
//    Console.WriteLine($"sua idade é {idade}, voce é menor de idade");
//}
*/

/*salario minimo e comum
//salario minimo ou salario comum

const decimal salarioMinimo = 1518m;

Console.WriteLine("digite o salario do funcionario: R$ ");
decimal salarioFuncionario = decimal.Parse(Console.ReadLine());


if (salarioFuncionario == salarioMinimo)
{
    Console.WriteLine($"o salario do funcionario é: {salarioFuncionario:C}");
}
else
{
    Console.WriteLine($"o funcionario NÃO recebe o salario minimo. {salarioFuncionario:C}");
}
*/


float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;

Console.WriteLine("Informe a operação matematica:\n" +
    " + = soma \n" + 
    " - = subtração \n" + 
    " * = multiplicação \n " + 
    " / = divisão");

operacaoMatematica = Console.ReadLine();

Console.WriteLine("informe o primeiro valor");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("informe o segundo valor");
num2 = float.Parse(Console.ReadLine());

if (operacaoMatematica == "+")
{
    Console.WriteLine($"Soma: {(num1 + num2):F2}");
}
else if (operacaoMatematica == "-")
{
    Console.WriteLine($"Subtração: {num2 - num1}");
}
else if (operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicação: {num1 * num2}");
}
else if (operacaoMatematica == "/")
{
    Console.WriteLine($"Divisão: {num2 / num1}");
}
else { Console.WriteLine("OPERAÇÃO invalida"); }
