string[] snacks = { "sushi", "pizza", "burger", "thai", "ramen" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");

string[] colors = { "red", "green", "blue", "pink", "yellow" };
for (int i = colors.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{colors.Length - i}.{colors[i]}");
}
