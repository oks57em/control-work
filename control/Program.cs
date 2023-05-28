// написать программу,которая из имеющегося массива строк формирует
// массив из строк,длина которых либо меньше либо равна 3 символа.
// первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте вполнения алгоритма.

Console.Write("Сколько элементов Вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
for (int i=0;i<size;i++)
{
    Console.WriteLine($"Введите{i+1} элемент:");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}
string[] arrayFinal = new string[size];
int len =3;
int pos =0;

for (int j =0; j< size;j++)
{ 
     if(arrayStrings[j].Length <= len)
     {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
     }
}
Console.WriteLine();

    
