Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

while (day < 1 || day > 7)
{
    Console.Write("Вы ошиблись! Ведите день недели: ");
    day = Convert.ToInt32(Console.ReadLine());
}
    if(day == 6 || day == 7)Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочие будни");
    

