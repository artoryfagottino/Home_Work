
Console.WriteLine("Здравствуйте!Эта программа поможет вам выбрать фильм");
Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Здраствуйте, "+ name);
Console.WriteLine("Фильм какого жанры вы предпочитаете: комедия,ужасы,драмма,фантастика?");
string genre = Console.ReadLine();
 Console.WriteLine();
 
 Console.WriteLine("**Есть такие фильмы: ");
if(genre == "комедия")
{
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("* Операция Ы ");
  Console.WriteLine("* 1+1 ");
  Console.WriteLine("* Назад в Будущее");
}

else if (genre == "фантастика")
{
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("* Черепашки Ниндзя");
  Console.WriteLine("* Люди Х");
    
}
else if (genre == "ужасы")
{
  Console.ForegroundColor = ConsoleColor.DarkYellow;
  Console.WriteLine("* Оно");
  Console.WriteLine("* Звонок");
} 
else
{
   
    Console.WriteLine("Зеленная миля ");
    Console.WriteLine("Побег из Шоушенга");

}
Console.ReadLine();
