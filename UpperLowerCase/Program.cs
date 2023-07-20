
public class program
{
public static void Main(string[] args)
    {
        Console.Write("Please Give the string value : ");
        string str;
       str=(Console.ReadLine());



        Console.Write("After conversion, the string is : ");

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (char.IsLower(ch))
                Console.Write(char.ToUpper(ch)); 
            else
                Console.Write(char.ToLower(ch)); 
        }

    

    }
}