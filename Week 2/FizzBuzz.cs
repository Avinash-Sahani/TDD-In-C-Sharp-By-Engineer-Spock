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
    [Test]
    public void TestFizzBuzz()
    {
        Assert.AreEqual("Fizz",FizzBuzz(3));
    }
    
    private string FizzBuzz(int number)
    {
        return "Fizz";
        
    }
}