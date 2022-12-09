Console.Clear();
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int tempnumber = number;

int length = 0;

while (number >= 1)
{
    number = number / 10;
    length = length + 1;
}
// Console.WriteLine($"Длина числа составляет: {length}");

if (length < 3)
    Console.WriteLine($"Нет третьей цифры нет. Длина числа составляет: {length} ");

int multiplier = 1;
for (int i = 1 ; i < length-2 ; i++)
    multiplier = multiplier * 10;

// Console.WriteLine($"Множитель: {multiplier}");
Console.WriteLine($"Третье число равно: {(tempnumber / multiplier % 10)}");
