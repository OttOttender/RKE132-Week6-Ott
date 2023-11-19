//hello 5 t2hte
//01234 asukoha index alati t2henumber - 1 //length - 1

//string hello = "hello, world! Here I am.";
string hello = "we are the champions?";


int stringLength = hello.Length;

//string trimmedString = hello.Trim(); //kustutab tuhiku enne ja parast sona

hello = hello.Trim(); //kustutaks varasem muutuja ja asendatakse see, et v2hendada vahe malu suurust

char firstLetter = hello[0];

Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace(hello[20], '!'); //voi hello[20] asemel '?'


firstLetter = hello[0];
Console.WriteLine(firstLetter);
Console.WriteLine(hello);
//string andmed immutable

//int wordCounter = 1;
////Console.WriteLine($"{i} symbol in tring {hello[i]}");
//for (int i = 0; i < hello.Length; i++) 
//{
//    // if(hello[i] == ' ') 
//    //{
//    //  wordCounter++;
//    //}
//    //if (char.IsWhiteSpace(hello[i])) //syboliga false tuhikuga true
//    //{
//    //    wordCounter++;
//    //}  
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");