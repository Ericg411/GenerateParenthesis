namespace GenerateParenthesis.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        List<string> answer = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };
        var result = _test.GenerateParenthesisFunction(3);

        bool pass = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i] != result[i])
            {
                pass = false;
            }
        }

        Assert.IsTrue(pass);
    }

    [TestMethod]
    public void TestMethod2()
    {
        List<string> answer = new List<string>() { "()" };
        var result = _test.GenerateParenthesisFunction(1);

        bool pass = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i] != result[i])
            {
                pass = false;
            }
        }

        Assert.IsTrue(pass);
    }

    [TestMethod]
    public void TestMethod3()
    {
        List<string> answer = new List<string>() { "(((())))", "((()()))", "((())())", "((()))()", 
                                                    "(()(()))", "(()()())", "(()())()", "(())(())", 
                                                    "(())()()", "()((()))", "()(()())", 
                                                    "()(())()", "()()(())", "()()()()" };
        var result = _test.GenerateParenthesisFunction(4);

        bool pass = true;

        for (int i = 0; i < answer.Count; i++)
        {
            if (answer[i] != result[i])
            {
                pass = false;
            }
        }

        Assert.IsTrue(pass);
    }
}