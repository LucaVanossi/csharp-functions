// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci i numeri che vuoi siano contenuti nell'array ");

int numeriInseririUtente = int.Parse(Console.ReadLine());
int [] ArrayEsercizio = new int [numeriInseririUtente];

for (int i = 0; i < numeriInseririUtente; i++) 
{
    int numero = int.Parse(Console.ReadLine());
    ArrayEsercizio [i] = numero;
} 


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

