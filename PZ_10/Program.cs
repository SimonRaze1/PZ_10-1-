using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();
        string output = ModifyText(input);
        Console.WriteLine("Модифицированный текст:");
        Console.WriteLine(output);
    }

    static string ModifyText(string input)
    {
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
                else
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }
        }
        return new string(chars);
    }
}

