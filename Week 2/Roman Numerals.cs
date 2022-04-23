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
    [TestCase(2,"II")]
    [TestCase(4,"IV")]
    [TestCase(15,"XV")]
    [TestCase(14,"XIV")]
    [TestCase(90,"XC")]



    

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
        var finalNumber = 0;

        for (var i = 0; i < roman.Length; i++)
        {
            if (CanSubtract(i))
            {
                finalNumber -= GetValue(i);
            }
            else
                finalNumber += GetValue(i);
        }

        return finalNumber;

        bool CanSubtract(int index) => IsComparable(index) && GetValue(index) < GetValue(index + 1);

        bool IsComparable(int index) => index + 1 < roman.Length;
        
        int GetValue(int index) => romanDictionary[roman[index]];
    }


}