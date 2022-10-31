int eded = 97;
int bolenlerinSayi = 0;
if (eded == 1)
{
    Console.WriteLine("Ne sade ne murekkebdir.");
}
else
{
    for (int i = 2; i <eded; i++)
    {
        if (eded%i == 0)
        {
            bolenlerinSayi++;
        }
    }
    if(bolenlerinSayi == 0)
{
    Console.WriteLine("Eded sadedir.");
}
else
{
    Console.WriteLine("Eded murekkebdir.");
}
}
