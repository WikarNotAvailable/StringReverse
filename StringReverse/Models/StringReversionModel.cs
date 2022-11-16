namespace StringReverse.Models
{
    public class StringReversionModel
    {
        public StringReversionModel() { }

        public string ReverseString(string stringToReverse)
        {
            if (stringToReverse.Length > 0)
                return stringToReverse[stringToReverse.Length - 1] + ReverseString(stringToReverse.Substring(0, stringToReverse.Length - 1));
            else
                return stringToReverse;
        }
    }
}
