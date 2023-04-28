using FluentAssertions;
using TestTask.Solution.Dictionaries;
using TestTask.Solution.Enums;

namespace TestTask.UnitTests.DictionaryTests; 

public class UnitNameDictionaryTest {

    [Theory]
    [InlineData(0, 0, Cases.Nominative, "")]
    [InlineData(1, 0, Cases.Nominative, "тысяча")]
    [InlineData(1, 1, Cases.Nominative, "тысячи")]
    [InlineData(1, 1, Cases.Accusative, "тысячи")]
    [InlineData(1, 2, Cases.Nominative, "тысяч")]
    [InlineData(1, 2, Cases.Accusative, "тысяч")]
    [InlineData(2, 1, Cases.Nominative, "миллиона")]
    [InlineData(2, 0, Cases.Nominative, "миллион")]
    public void Test(int scale, int scaleNameForm, Cases @case, string result) {
        UnitNameDictionary.GetNumberScaleName(scale, scaleNameForm, @case).Should().Be(result);
    }
}