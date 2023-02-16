namespace GenerateParenthesis;
public class Class1
{

    IList<string> result = new List<string>();
    int maxValue;

    public IList<string> GenerateParenthesisFunction(int n)
    {
        maxValue = n;

        GenerateCheck("", 0, 0);

        return result;
    }

    public void GenerateCheck(string str, int open, int close)
    {
        if (open == close && open == maxValue)
        {
            result.Add(str);
        }
        else
        {
            if (open < maxValue)
            {
                GenerateCheck(str + "(", open + 1, close);
            }
            if (close < open)
            {
                GenerateCheck(str + ")", open, close + 1);
            }
        }
    }



}
