//string Method4(int count, string text)
//{
    
   // string result = String.Empty;
   // //for(int i = 0; i< count; i++)
   // {
   //     result = result + text;
   // }
   // return result;
//}

//string res = Method4(10, "z");
//Console.WriteLine(res);

//цикл в цикле
//for (int i = 2; i <= 10; i++)
//{
 //   for (int j = 2; j <= 10; j++)
 //   {
 //       Console.WriteLine($"{i} x {j} = {i* j}");
 //   Console.WriteLine();
 //   }
//}

//исправляем буквы в тексте
string text  = "Cc Сс Чч Лл Кк Kk";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; ++i)
    {
        if(text[i] == oldValue) result = result  + $"{newValue}";
        else result = result + $"{ text [i]}"; 
    }
    

    return result;
}
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', '1');
Console.WriteLine(newText);