Console.WriteLine("Третья задача на определение чётности введённого числа");

bool valid = false;
int num1 = 0;

while (valid == false) {
Console.WriteLine("Введите число: ");
string? str = Console.ReadLine();
if(int.TryParse(str, out int number1)) {
    num1 = number1;
    valid = true;
}
else Console.WriteLine("Некорректно введено число!");
}

if(num1 % 2 == 0) {
    Console.WriteLine("Введённое Вами число - чётное!");
    }
    else Console.WriteLine("Введённое Вами число - НЕчётное!");