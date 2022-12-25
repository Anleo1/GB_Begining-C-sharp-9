int function(int n, int m){
    if (n == 0) return (m + 1);
    else if(m == 0) return function((n - 1), 1);
    else return function((n - 1), function(n, (m-1))); //
}

Console.Write("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 >= 0 && number2 >= 0){
    Console.WriteLine($"A(m,n) = {function(number1, number2)}");
}
else {
    Console.WriteLine($"Оба числа не должны быть отрицательными");
}