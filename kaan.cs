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
/*
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
*/
/*
Console.WriteLine("Please enter your midterm and final exam scores.");
int mid = Int32.Parse(Console.ReadLine());
int final = Int32.Parse(Console.ReadLine());
double score = mid*0.4 + final*0.6;
if (score => 50){
    Console.WriteLine("PASSED !");
}
else{
    Console.WriteLine("FAILED !");
}
Console.ReadKey();
*/
/*
Console.WriteLine("Please enter a number");
int x = Int32.Parse(Console.ReadLine());
int res = 0;
if (x > 5){
    res = (3*x+10);
}
else if (x == 5){
    res = 0
}
else{
    res = ((1/2)^x + 15);
}
Console.WriteLine(res);
Console.ReadKey();
*/
/*
Console.WriteLine("Please type a day name.");
string dayName = Console.ReadLine();
string dayStatus =""
switch[dayName]{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
          dayStatus = "weekday"; break;
    case "saturday":
    case "sunday":
                dayStatus = "weekend"; break;
}
Console.ReadKey();

*/

Console.WriteLine("Please enter a number");
int a = Int32.Parse(Console.ReadLine());
int h = Int32.Parse(Console.ReadLine());
area_of_triangle = (a*h)/2
if(area_of_triangle < 0){
    Console.WriteLine("The area of triangle can't be less than 0, please try a different number.");
}
else{
    Console.WriteLine(area_of_triangle);
}
Console.ReadKey();
