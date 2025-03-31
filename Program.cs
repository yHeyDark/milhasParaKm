double milhas, km;

Console.Write("Digite a medida (milhas): ");
milhas = Convert.ToDouble(Console.ReadLine());
km = milhas*1.609;
Console.WriteLine($"{km} km");