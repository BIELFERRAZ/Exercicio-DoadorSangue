int idade;

Console.WriteLine("Qual sua idade:");
idade = Convert.ToInt32 (Console.ReadLine());

if (idade >18 && idade <68 )
{
    Console.WriteLine("Você pode ser Doador.");
}

else
{
    Console.WriteLine("Você não pode ser Doador. ");
}