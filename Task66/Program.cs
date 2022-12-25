int function(int n1, int n2){
    int sum = 0;
    if(n2>=n1){
        sum = function(n1, (n2-1)) + n2;
    }
    return sum;
}

Console.Write("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2){
    Console.WriteLine($"Сумма чисел, от {number2} до {number1} = {function(number2, number1)}");
}
else{
    Console.WriteLine($"Сумма чисел, от {number1} до {number2} = {function(number1, number2)}");
}