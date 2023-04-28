using TestTask.Solution.Dictionaries;
using TestTask.Solution.Enums;

namespace TestTask.Solution;

public static class Converter {

    /// <summary>
    /// Конвертация числа в строку прописью
    /// </summary>
    /// <param name="value">Число</param>
    /// <param name="case">Падеж</param>
    /// <param name="genus">Род</param>
    /// <returns>Число прописью</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> вне диапазона 0 - 999 999 999 999</exception>
    public static string ConvertNumToWord(long value, Cases @case, Genus genus) {
        if (value > 999_999_999_999 && value < 0) {
            throw new ArgumentOutOfRangeException($"Значение '{nameof(value)}' должно быть от 0 до 999 999 999 999");
        }

        var listOfWords = new List<string>();
        var grouped = SplitNumberToGroups(value);
        var countOfGroups = grouped.Length;
        var iteration = 0;
        foreach (var group in grouped) {
            iteration++;
            
            var digit1 = group[0] - '0';
            var digit2 = group[1] - '0';
            var digit3 = group[2] - '0';

            if (digit1 is 0 && digit2 is 0 && digit3 is 0) {
                if (countOfGroups is 1) {
                    var word = UnitNumberDictionary.NumberToWord(digit3, @case, genus);
                    listOfWords.Add(word);
                    break;
                }
                
                // пропускаем группу
                continue;
            }

            if (digit1 > 0) {
                var word1 = HundredNumberDictionary.NumberToWord(digit1 * 100, @case, genus);
                listOfWords.Add(word1);
            }

            var digit23 = digit2 * 10 + digit3;

            if (digit23 > 9 && digit23 < 20) {
                var word23 = TenToNineteenNumberDictionary.NumberToWord(digit23, @case, genus);
                listOfWords.Add(word23);
            }
            else {
                if (digit2 > 1) {
                    var word2 = TenNumberDictionary.NumberToWord(digit2 * 10, @case, genus);
                    listOfWords.Add(word2);
                }

                if (digit3 > 0) {
                    var word3 = UnitNumberDictionary.NumberToWord(digit3, @case, genus);
                    listOfWords.Add(word3);
                }
            }
            
            // магия с классами единиц
            var scaleForm = 2;

            if (digit3 > 0 && digit3 < 5) {
                scaleForm = digit3 == 1 ? 0 : 1;
            }
            
            var currentNumberScale = countOfGroups - iteration;
            
            // получение наименования класса единицы
            var scaleName = UnitNameDictionary.GetNumberScaleName(currentNumberScale, scaleForm, @case);

            if (scaleName.Equals(string.Empty)) {
                continue;
            }
            
            listOfWords.Add(scaleName);
        }

        return string.Join(' ', listOfWords);
    }

    /// <summary>
    /// Преобразование числа в строковые группы, по 3 цифры каждая, например: <br/>
    /// 12 -> 012 <br/>
    /// 19234 -> 019 234 <br/>
    /// 2834465 -> 002 834 465
    /// </summary>
    /// <param name="value">Число на преобразование</param>
    /// <returns>Группы цифр</returns>
    private static string[] SplitNumberToGroups(long value) {
        const int chunkSize = 3;

        var strValue = value.ToString();

        // расчет не хватки нулей для самой первой группы
        var del = strValue.Length % chunkSize;
        var countOfZeroToAdd = del == 0 ? 0 : chunkSize - del;

        var str = new string('0', countOfZeroToAdd) + strValue;

        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(e => str.Substring(e * chunkSize, chunkSize))
            .ToArray();
    }
}