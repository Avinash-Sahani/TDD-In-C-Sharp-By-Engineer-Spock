namespace TDD_In_C_Sharop_By_Engineer_Spock;
using NUnit.Framework;

//Fizz Buzz is simple program in which
/*
 * DIv BY 3 => "Fizz"
 * Div By 5 => "Buzz"
 * Div BY 3 and 5 => "Fizz Buzz"
 * else => string.Empty
 * 
 */
[TestFixture]
public class FizzBuzzTests
{
    [TestCase("Fizz",3)]
    [TestCase("Buzz",5)]
    [TestCase("Fizz",6)]
    [TestCase("Buzz",10)]
    [TestCase("Fizz Buzz",15)]
    [TestCase("Buzz",20)]
    [TestCase("Fizz",18)]


    public void TestFizzBuzz(string expected,int number)
    {
        Assert.AreEqual(expected,FizzBuzz(number));
    }
    
    private string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
            return "Fizz Buzz";
        if(number%3==0)
            return "Fizz";
        if (number % 5 == 0)
            return "Buzz";
        
        return string.Empty;

    }
}