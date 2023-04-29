using TestTask.Solution.Enums;

namespace TestTask.Solution.Dictionaries;

public static class UnitNameDictionary {

    private static Dictionary<Cases, string[]> _thousandNames = new() {
        { Cases.Nominative, new[] { "тысяча", "тысячи" } },
        { Cases.Genitive, new[] { "тысячи", "тысяч" } },
        { Cases.Dative, new[] { "тысяче", "тысячам" } },
        { Cases.Accusative, new[] { "тысячу", "тысячи" } },
        { Cases.Instrumental, new[] { "тысячей", "тысячами" } },
        { Cases.Prepositional, new[] { "тысяче", "тысячах" } }
    };

    private static Dictionary<Cases, string[]> _integerWordEndings = new() {
        { Cases.Nominative, new[] { "", "ы" } },
        { Cases.Genitive, new[] { "а", "ов" } },
        { Cases.Dative, new[] { "у", "ам" } },
        { Cases.Accusative, new[] { "", "а" } },
        { Cases.Instrumental, new[] { "ом", "ами" } },
        { Cases.Prepositional, new[] { "е", "ах" } }
    };

    private static string[] _unitNames = {
        "миллион",
        "миллиард",
        "триллион",
    };

    /// <summary>
    /// Получение наименования класса единицы в правильном падеже
    /// </summary>
    /// <param name="scale">Индекс класса, где 0 - единицы, 1 - тысячи и т.д.</param>
    /// <param name="scaleNameForm">Форма падежа для наименования класса единиц (0 | 1 | 2)</param>
    /// <param name="case">Падеж</param>
    /// <returns>Наименование класс числа</returns>
    public static string GetNumberScaleName(int scale, int scaleNameForm, Cases @case) {
        // единицы не имеют наименования класса
        if (scale < 1) {
            return string.Empty;
        }

        if (scale > _unitNames.Length + 1) {
            throw new ArgumentOutOfRangeException($"Индекс класса '{scale}' не поддерживается");
        }

        var scalePlural = scaleNameForm == 0 ? 0 : 1;

        // Если падеж именительный или винительный и множественное число
        if ((@case == Cases.Nominative || @case == Cases.Accusative) && scaleNameForm >= 1) {
            // Для множественного числа именительного падежа используется родительный падеж.
            @case = Cases.Genitive;
            scalePlural = scaleNameForm == 1 ? 0 : 1;
        }

        if (scale == 1) {
            return _thousandNames[@case][scalePlural];
        }

        var baseWord = _unitNames[scale - 2];
        var ending = _integerWordEndings[@case][scalePlural];
        return baseWord + ending;
    }
}