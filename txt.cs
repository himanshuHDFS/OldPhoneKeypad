using System;
using System.Collections.Generic;
using System.Text;

public class OldPhonePad
{
    public static string OldPhonePad(string input)
    {
        //Dictionary mapping as on keypad 
        var keypad = new Dictionary<char, string>
        {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        var result = new StringBuilder();
        char lastChar = '\0';
        int charCount = 0;

        foreach (var c in input)
        {
            if (c == '#')
            {
                // send message
                break;
            }
            else if (c == '*')
            {
                // Backspace
                if (result.Length > 0)
                {
                    result.Length -= 1;
                }
            }
            else if (keypad.ContainsKey(c))
            {
                if (c == lastChar)
                {
                    // Increment count if same key is pressed
                    charCount++;
                }
                else
                {
                    // Append last character if it's a new key
                    if (lastChar != '\0')
                    {
                        var letters = keypad[lastChar];
                        result.Append(letters[(charCount - 1) % letters.Length]);
                    }
                    lastChar = c;
                    charCount = 1;
                }
            }
        }

        // Append the last character
        if (lastChar != '\0')
        {
            var letters = keypad[lastChar];
            result.Append(letters[(charCount - 1) % letters.Length]);
        }

        return result.ToString();
    }

    public static void Main()
    {
        Console.WriteLine(OldPhonePad("33#")); // Output: E
        Console.WriteLine(OldPhonePad("227*#")); // Output: B
        Console.WriteLine(OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(OldPhonePad("8 88777444666*664#")); // Output: ????? (depends on backspaces)
    }
}
