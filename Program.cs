//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

/*
int Exponentiation (int numberA, int numberB)
{
    int current = 1;
    for (int i = 1; i <= numberB; i++)
    {
        current = current * numberA;
    }

    return current;
}

Console.WriteLine("Enter first number");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"Ответ {exponentiation}");
*/


// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
/*
Console.WriteLine("Enter number");
int enterNumber = Convert.ToInt32(Console.ReadLine());

int SumNumber(int enterNumber) 
{
    int counter = Convert.ToString(enterNumber).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = enterNumber - enterNumber % 10;
        result = result + (enterNumber - advance);
        enterNumber = enterNumber / 10;
    }
    return result;
}

int sumNumber = SumNumber(enterNumber);
Console.WriteLine($"the sum of the digits in a number = {sumNumber}");
*/



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateNewArray (int sizeArray){
    int [] randomArray = new int [sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(1, 10);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine("You array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    Console.Write(arrayToPrint[i] + " ");
}

int size = 8;
int [] firstArray = CreateNewArray(size);
PrintArray(firstArray);