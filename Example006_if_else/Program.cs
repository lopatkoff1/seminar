Console.Write("Введите имя пользоватиля:");
string username = Console.ReadLine();

if(username.ToLower()== "паша")
{
    Console.WriteLine("Ураа,это Паша");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}