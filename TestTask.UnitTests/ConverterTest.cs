using FluentAssertions;
using TestTask.Solution;
using TestTask.Solution.Enums;

namespace TestTask.UnitTests;

public class ConverterTest {
    
    [Theory]
    [InlineData(0, Genus.Male, Cases.Nominative, "ноль")]
    [InlineData(0, Genus.Male, Cases.Genitive, "ноля")]
    [InlineData(0, Genus.Male, Cases.Dative, "нолю")]
    [InlineData(0, Genus.Male, Cases.Accusative, "ноль")]
    [InlineData(0, Genus.Male, Cases.Instrumental, "нолём")]
    [InlineData(0, Genus.Male, Cases.Prepositional, "ноле")]
    [InlineData(1, Genus.Neuter, Cases.Nominative, "одно")]
    [InlineData(1, Genus.Male, Cases.Nominative, "один")]
    [InlineData(1, Genus.Female, Cases.Nominative, "одна")]
    [InlineData(22, Genus.Neuter, Cases.Instrumental, "двадцатью двумя")]
    [InlineData(31, Genus.Male, Cases.Genitive, "тридцати одного")]
    [InlineData(524, Genus.Male, Cases.Genitive, "пятисот двадцати четырёх")]
    [InlineData(999, Genus.Male, Cases.Nominative, "девятьсот девяносто девять")]
    [InlineData(999, Genus.Female, Cases.Nominative, "девятьсот девяносто девять")]
    [InlineData(999, Genus.Male, Cases.Genitive, "девятисот девяноста девяти")]
    [InlineData(154_323, Genus.Male, Cases.Nominative, "сто пятьдесят четыре тысячи триста двадцать три")]
    [InlineData(154_323, Genus.Male, Cases.Instrumental, "ста пятьюдесятью четырьмя тысячами тремястами двадцатью тремя")]
    [InlineData(12_027_823, Genus.Male, Cases.Instrumental, "двенадцатью миллионами двадцатью семью тысячами восемьюстами двадцатью тремя")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Nominative, "девятьсот девяносто девять миллиардов девятьсот девяносто девять миллионов девятьсот девяносто девять тысяч девятьсот девяносто девять")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Genitive, "девятисот девяноста девяти миллиардов девятисот девяноста девяти миллионов девятисот девяноста девяти тысяч девятисот девяноста девяти")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Dative, "девятистам девяноста девяти миллиардам девятистам девяноста девяти миллионам девятистам девяноста девяти тысячам девятистам девяноста девяти")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Accusative, "девятьсот девяносто девять миллиардов девятьсот девяносто девять миллионов девятьсот девяносто девять тысяч девятьсот девяносто девять")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Instrumental, "девятьюстами девяноста девятью миллиардами девятьюстами девяноста девятью миллионами девятьюстами девяноста девятью тысячами девятьюстами девяноста девятью")]
    [InlineData(999_999_999_999, Genus.Male, Cases.Prepositional, "девятистах девяноста девяти миллиардах девятистах девяноста девяти миллионах девятистах девяноста девяти тысячах девятистах девяноста девяти")]
    public void Test(long num, Genus gender, Cases @case, string result) {
        Converter.ConvertNumToWord(num, @case, gender).Should().Be(result);
    }
}