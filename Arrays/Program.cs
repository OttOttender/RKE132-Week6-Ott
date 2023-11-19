

//string[] fruit = { "apples", "bananas", "oranges" }; //ainult string, booleani ei saa prgu
string[] fruit = new string[3]; //range suurusega jne fruit[0], fruit [1], fruit [2] ja nendesse saab salvestada andmeid

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}"); //jne

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array.");

for (int i = 0; i < fruitArrayLength; i++)
{
    //Console.WriteLine(fruit[i]);
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); //ei saa teha nt foreachis
}

foreach (string temporaryElement in fruit)
{
    Console.WriteLine(temporaryElement);
} //v2imaldab displayida aga mitte sisuliselt muuta neid andmeid failis