char[] carac = new char[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}° caracter");
    carac[i] = char.Parse( Console.ReadLine() );
}
for (int j = 0; j < 10; j++)
{
    if (carac[j] == 'a' || carac[j] == 'e' || carac[j] == 'i' || carac[j] == 'o' || carac[j] == 'u')
    {
        if (carac[j] == 'a')
        {
            carac[j] = 'A';
        }
        if (carac[j] == 'e')
        {
            carac[j] = 'E';
        }
        if (carac[j] == 'i')
        {
            carac[j] = 'I';
        }
        if (carac[j] == 'o')
        {
            carac[j] = 'O';
        }
        if (carac[j] == 'u')
        {
            carac[j] = 'U';
        }

    }
    
}
Console.WriteLine(carac);