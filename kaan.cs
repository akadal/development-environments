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