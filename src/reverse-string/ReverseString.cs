public class ReverseString
{
    public string Reverse(string input)
    {
        if(string.IsNullOrEmpty(input)){
            throw new ArgumentNullException(nameof(input));
        }

        var charStack = new Stack<char>();
        var charArray = input.ToCharArray();

        for(int i =0; i<charArray.Length; i++)
        {
            if(!char.IsLetter(charArray[i])) continue;
            charStack.Push(charArray[i]);            
        }
        
        for(int i =0; i<charArray.Length; i++)
        {                        
            if(!char.IsLetter(charArray[i])) continue;
            charArray[i] = charStack.Pop();
        }
        
        var output = new string(charArray);
        return output;
    }
}