//генерация температуры с условиями.

Random random = new Random(); //создаем экземпляр класса рандом

int temperature = 0; //переменная, в которую будут записываться значения температуры

for(int i=1;  i<=100; i++)
{
    temperature = random.Next(1, 101); //генерируем температуру от 1 до 100

    if(temperature<90) Console.WriteLine(temperature+" градуса(ов) - входит в норму ");

    else if (temperature==90) Console.WriteLine(temperature+ " градуса(ов) - кристическая температура ");

    else
    {
        Console.WriteLine(temperature+ " градуса(ов) - критическая температура");
        break; //прерываем программу
    }
}
