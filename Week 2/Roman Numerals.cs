using NUnit.Framework;

namespace TDD_In_C_Sharop_By_Engineer_Spock;
/*
 * Program To Convert Roman Numerals To Number Using TDD Approach
 * We will be using the subtractive notaion approach like (IIII= IV) in Roman
 * 
 */
[TestFixture]
public class Roman_Numerals
{
    [TestCase(1, "I")]
    [TestCase(5,"V")]
    [TestCase(10,"X")]
    [TestCase(50,"L")]
    [TestCase(100,"C")]
    [TestCase(500,"D")]
    [TestCase(1000,"M")]
    [TestCase(4,"IV")]
    

    

    public void TestRomanNumerals(int expected, string roman)
    {
        Assert.AreEqual(expected, RomanToNumber(roman));
    }

    public int RomanToNumber(string roman)
    {
        var romanDictionary = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}

        };
        return romanDictionary[roman[0]];
    }
}