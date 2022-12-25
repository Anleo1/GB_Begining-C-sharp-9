void funct(int N){
    if (N > 0){
        Console.Write($"{N} ");
        funct(N-1);
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0){
        Console.WriteLine($"Введите число, больше нуля");
    }
funct(number);