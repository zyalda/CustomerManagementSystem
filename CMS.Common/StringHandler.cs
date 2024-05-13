namespace CMS.Common
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            String result = string.Empty;
            if (!string.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter) && !char.IsWhiteSpace(letter))
                    {
                        result += " ";
                    }
                    else
                        result = result.Trim();
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }

    }
}
