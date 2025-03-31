Console.Clear();

double adultos, pessoas, adultosNaoBebem, adultosBebem, criancas, carne, acompanhamentos, cerveja, refrigerante, agua;

Console.Write("Adultos (que consomem bebidas alcoólicas): ");
adultosBebem = Convert.ToDouble(Console.ReadLine());

Console.Write("Adultos (que não consomem bebidas alcoólicas): ");
adultosNaoBebem = Convert.ToDouble(Console.ReadLine());

Console.Write("Crianças: ");
criancas = Convert.ToDouble(Console.ReadLine());

adultos = adultosBebem + adultosNaoBebem;
pessoas = adultos + criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultosBebem;
refrigerante = 0.5 * (adultosNaoBebem + criancas);
agua = 0.4 * pessoas;


Console.WriteLine($"Carne: {carne:N2}kg");
Console.WriteLine($"Acompanhamentos: {acompanhamentos:N2}kg");
Console.WriteLine($"Cerveja: {cerveja:N2}l");
Console.WriteLine($"Refrigerante: {refrigerante:N2}l");
Console.WriteLine($"Água: {agua:N2}l");






