// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num = ReadInt("Введите число A: ");
int num1 = ReadInt("Введите число B: ");
ToDegree(num, num1);

void ToDegree(int num, int num1)
{
    int result = 1;
    for (int i = 1; i <= num1; i++)
    {
        result = result * num;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}