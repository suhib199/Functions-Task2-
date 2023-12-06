
//Q1
using System.Text;

int NumberOfDays(DateTime date1, DateTime date2)
{
    Console.WriteLine("The number of days");

    TimeSpan days = date2 - date1;

    return days.Days;
}

Console.WriteLine(NumberOfDays(new DateTime(199, 3, 20), new DateTime(199, 3, 25)));

Console.WriteLine("-------------------------------------------------");


//Q2
string[] arrayContainNumbers(string[] arr)
{
    int counter = 0;
    string[] arr2 = new string[counter];

    foreach (var pointer in arr)
    {
        foreach (var pointer2 in pointer)
        {
            int check;
            if (int.TryParse(pointer2.ToString(), out check))
            {
                counter++;
            }
        }
    }
    counter = 0;
    foreach (var pointer in arr)
    {
        foreach (var pointer2 in pointer)
        {
            int check;

            if (int.TryParse(pointer2.ToString(), out check))
            {
                arr2[counter] = pointer;
                counter++;

            }
        }
    }



    return arr2;
}

foreach (var elment in arrayContainNumbers(new string[2] { "abc", "abc10" }))
{
    Console.WriteLine(elment);
}


//Q3  
string word(string word)
{
    char[] reverse;
    string[] strings = word.Split(' ');


    if (word.Length % 2 == 1)
    {
        reverse = word.ToCharArray();
        Array.Reverse(reverse);
        string d = new string(reverse);
        return d;



    }
    else
        return word;
}

Console.WriteLine(word("ali"));




//Q4
static bool isPandigital(long num)
{

    string numStr = num.ToString();

    HashSet<char> digitSet = new HashSet<char>();

    foreach (char digit in numStr)
    {
        if (char.IsDigit(digit))
        {
            digitSet.Add(digit);
        }
    }

    return digitSet.Count == 10;
}

long number = 98140723568910;
Console.WriteLine(isPandigital(number));



//Task3
//Q1
float add(float number)
{
    Console.WriteLine("Please enter a number");
float num = Convert.ToSingle(Console.ReadLine());

return number + num;

}
Console.WriteLine(add(10));



//Q2
string removeTheZeros (string num)
{
    Console.WriteLine ("Number without zeros = ");
float num2 = Convert.ToSingle(num);
return num2.ToString();

}
Console.WriteLine("Please enter the number");
Console.WriteLine(removeTheZeros(Console.ReadLine()));


//Q3
float secondLargestNumber(float[] arr)
{
    Array.Sort(arr);
    Array.Reverse(arr);
    return arr[1];


}

Console.WriteLine($"The scond largest number is = {secondLargestNumber(new float[] { 10, 40, 30, 20, 50 })} ");


//Q4

bool repdigit()
{
    Console.WriteLine("Enter any number to check it");
float num = Convert.ToSingle(Console.ReadLine());
if (num > 0)
{
    return true;
}
else
    return false; 

}
Console.WriteLine(repdigit());


//Q5



string[] reverseWord(string word)
{

    string[] wordSplit = word.Split(" ");
    Array.Reverse(wordSplit);
    return wordSplit;
}



Console.WriteLine("The sentence after reverse:");
foreach (var pointer in reverseWord(Console.ReadLine()))
{

    Console.Write(pointer + " ");
}


//Q6
string ArrayOfNumbers (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i].ToString()).Contains('7'))
        {
            return "Boom!";

        }

    }
    return "there is no 7 in the array";



}
Console.WriteLine(ArrayOfNumbers(new int[] { 2, 55, 60, 97, 86 }));

//Q7

string addSpace(string word)
{
    string newWord = "";
for (int i = 0; i < word.Length - 1; i++)
{
    if (((int)word[i] <= 122 && (int)word[i] >= 97) && ((int)word[i + 1] <= 90 && (int)word[i + 1] >= 65))
    {
        newWord = word.Insert((i + 1), " ");
        word = newWord;
    }
}

return newWord;
}
Console.WriteLine(addSpace(Console.ReadLine()));


//Q8
int countTrue(bool[] array)
{
    int count = 0;

    foreach (bool value in array)
    {
        if (value)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(countTrue(new bool[] { true, false, false, true, false }));


//Q9


string CapToFront(string word)
{
    System.Text.StringBuilder result = new StringBuilder();

    foreach (char ch in word)
    {
        if (char.IsUpper(ch))
        {
            result.Append(ch);
        }
    }

    foreach (char ch in word)
    {
        if (char.IsLower(ch))
        {
            result.Append(ch);
        }
    }

    return result.ToString();
}

Console.WriteLine(CapToFront("moveMENT"));


//Q10

bool MatchLastItem(object[] items)
{
    string concatenatedRest = string.Concat(items.Take(items.Length - 1).Select(item => item.ToString()));
    return string.Equals(items.LastOrDefault()?.ToString(), concatenatedRest, StringComparison.Ordinal);
}
Console.WriteLine(MatchLastItem(new object[] { 1, 1, 1, "11" }));

//Q11
int FindNaN(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (double.IsNaN(numbers[i]))
        {
            return i;
        }
    }

    return -1;
}
Console.WriteLine(FindNaN(new double[] { 0, 1, 2, 3, 4 }));


//Q12
static string ConvertTime(string time)
{
    DateTime parsedTime = DateTime.ParseExact(time, "hh:mm:sstt", null);

    string militaryTime = parsedTime.ToString("HH:mm:ss");

    return militaryTime;
}



//Q15
int SumOfCubes(int[] numbers)
{
    return numbers.Sum(x => (int)Math.Pow(x, 3));
}