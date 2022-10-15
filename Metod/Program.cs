// Методы :
// 1. Ничего не возвращают и ничего не принимают
/*
void Method1()
{
    Console.WriteLine("Автор");
}
Method1();
*/
// 2. Ничего не возвращают, но могут принимать какие либо аргументы
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый Текст");
*/

//3. Возвращают, но ничего не принимают
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

*/

// 4. Принимают и возвращают
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/
// Цикл со счетчиком for
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)

    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
*/
