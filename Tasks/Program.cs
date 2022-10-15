//                  Ясна ли задача?
// Что значит дан текст?(как отдельная строка, ввел пользователь, взяли из базы данных)
// Что значит черточками?(тире, дефисы, минусы)
// Какой алфавит?(кирилица, латиница)

// Дан текст. В тексте нужно все пробелы заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винцентгероде,"
            + "вы бы взяли приступом согласие прусского короля ";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);