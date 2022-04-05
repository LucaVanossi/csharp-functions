// See https://aka.ms/new-console-template for more information

int[] ArrayEsercizio = { 2, 6, 7, 5, 3, 9 };

//  int numerivoluti = 5; 
//  int [] ArrayEsercizio = new int [numerivoluti];
// for ....

StampaArrayInteri(ArrayEsercizio);
StampaArrayInteri(ElevaArrayAlQuadrato(ArrayEsercizio));

int risultato = sommaElementiArray(ArrayEsercizio);
Console.WriteLine("La somma dei numeri dell'array è " + risultato);

int SommaQuadrati = sommaElementiArray(ElevaArrayAlQuadrato(ArrayEsercizio));
Console.WriteLine("La somma dei nummeri degli array elevati al quadrato è " + SommaQuadrati);

/* FUNZIONI */

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



int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] CopiaArray = (int[])array.Clone();

    for (int i = 0; i < array.Length; i++)
    {
        CopiaArray[i] = Quadrato(CopiaArray[i]);
    }
    return CopiaArray;
}



int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}

