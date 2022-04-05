// See https://aka.ms/new-console-template for more information

void StampaArrayInteri(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}



int Quadrato(int numero)
{
    int risultato = (numero * numero);
    return risultato;
}

/*int NumeroFinale = Quadrato(5);
Console.WriteLine(NumeroFinale);*/   



