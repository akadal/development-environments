/*
Random num = new Random();
int a = 0;
int gen_num = num.Next(60);
bool b = false;
int count = 0;
do{
    Console.WriteLine("Please guess the number between 1-60.");
    count++;
    a = Convert.ToInt32(Console.ReadLine());
    if (a < gen_num){
        Console.WriteLine("Please try big number");
    }
    else if (a > gen_num){
        Console.WriteLine("Please try small number");
    }
    if (a == gen_num){
        Console.WriteLine($"You guessed number {count} times !");
    }
}
while(b==false);
*/

Console.WriteLine("Please your point's coordinates.");
int x = Int32.Parse(Console.ReadLine());
int y = Int32.Parse(Console.ReadLine());
if (x > 0 && y > 0){
    Console.WriteLine("The point is in the first region.");
}
else if (x < 0 && y > 0){
    Console.WriteLine("The point is in the second region.");
}
else if (x < 0 && y < 0){
    Console.WriteLine("The point is in the third region.");
}
else if (x > 0 && y < 0){
    Console.WriteLine("The point is in the fourth region.");
}
Console.ReadKey();