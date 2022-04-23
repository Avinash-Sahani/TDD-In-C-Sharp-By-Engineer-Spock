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

    public void TestRomanNumerals(int expected, string roman)
    {
        Assert.AreEqual(expected, RomanToNumber(roman));
    }

    private int RomanToNumber(string roman)
    {
        if (roman == "V")
            return 5;
        if (roman == "X")
            return 10;
        if (roman == "L")
            return 50;
        return 1;
    }
}