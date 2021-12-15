// вид 1       не принимают не возвращают
//void Method1()
//{
    //Console.WriteLine("Автор...");
//}
//Method1();



//вид2           что то принимает но не возвращает
//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//} 
//Method2(msg: "Текст сообщения");
//void Method21(string msg, int count)
//{
 //   int i  =0;
  //  while (i < count)
  //  {
        //Console.WriteLine(msg);
   //     ++i;
  //  }
//}
//Method21(msg: "Текст", count: 4);



//вид3        не принимают но возвращают
//1int Method3()
//{
//    return DateTime.Now.Year;
//}

//int year = Method3();
//Console.WriteLine(year);


// 4 принимают и отправляют
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        ++i;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);



