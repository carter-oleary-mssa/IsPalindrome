bool isPalindrome(string s)
{
    char[] charArray = s.ToCharArray();
    List<char> newStringArray = new List<char>();
    for(int i = 0; i < charArray.Length; i++)
    {
        if (Char.IsLetterOrDigit(charArray[i]))
        {
            newStringArray.Add(Char.ToLower(charArray[i]));
        }
    }
    string newString = new string(newStringArray.ToArray());
    Console.WriteLine($"Initial String: {newString}");
    newStringArray.Reverse();
    string reversedString = new string(newStringArray.ToArray());
    Console.WriteLine($"Reversed String: {reversedString}");
    return newString == reversedString;
    
}

string s = "Race a car";
if(isPalindrome(s))
    Console.WriteLine($"{s} is a palindrome");
else
    Console.WriteLine($"{s} is not a palindrome");