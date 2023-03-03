string frase = "Etec Adolpho Berezin";
Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
for (int i = 0; i < frase.Length; i++)
{
    Console.Write(frase[i]);
    Thread.Sleep(100);
}
Console.ResetColor();