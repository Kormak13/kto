int c = 0;
char a = '6';
Console.WriteLine("введите число = ");
string s = Convert.ToString(Console.ReadLine());
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == a)
    {
        c++;
    }
}
Console.WriteLine("в числе есть цифра: " + a + " - " + c + " раз(а)");
//Задание: составить программу,которая определяет, есть ли цифра 6 в введенном числе
//Работу выполнил Попов Виталий (244-ИСП СИС)