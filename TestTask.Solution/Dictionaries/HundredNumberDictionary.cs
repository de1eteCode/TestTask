using TestTask.Solution.Enums;

namespace TestTask.Solution.Dictionaries; 

public static class HundredNumberDictionary {

    /// <summary>
    /// Числа 100-900 по падежам
    /// </summary>
    private static Dictionary<KeyValuePair<int, Cases>, string> _casesNumDictionary = new() {
        // 100
        { new KeyValuePair<int, Cases>(100, Cases.Nominative), "сто" },
        { new KeyValuePair<int, Cases>(100, Cases.Genitive), "ста" },
        { new KeyValuePair<int, Cases>(100, Cases.Dative), "ста" },
        { new KeyValuePair<int, Cases>(100, Cases.Accusative), "сто" },
        { new KeyValuePair<int, Cases>(100, Cases.Instrumental), "ста" },
        { new KeyValuePair<int, Cases>(100, Cases.Prepositional), "ста" },
        
        // 200
        { new KeyValuePair<int, Cases>(200, Cases.Nominative), "двести" },
        { new KeyValuePair<int, Cases>(200, Cases.Genitive), "двухсот" },
        { new KeyValuePair<int, Cases>(200, Cases.Dative), "двумстам" },
        { new KeyValuePair<int, Cases>(200, Cases.Accusative), "двести" },
        { new KeyValuePair<int, Cases>(200, Cases.Instrumental), "двумястами" },
        { new KeyValuePair<int, Cases>(200, Cases.Prepositional), "двухстах" },
        
        // 300
        { new KeyValuePair<int, Cases>(300, Cases.Nominative), "триста" },
        { new KeyValuePair<int, Cases>(300, Cases.Genitive), "трёхсот" },
        { new KeyValuePair<int, Cases>(300, Cases.Dative), "трёмстам" },
        { new KeyValuePair<int, Cases>(300, Cases.Accusative), "триста" },
        { new KeyValuePair<int, Cases>(300, Cases.Instrumental), "тремястами" },
        { new KeyValuePair<int, Cases>(300, Cases.Prepositional), "трёхстах" },
        
        // 400
        { new KeyValuePair<int, Cases>(400, Cases.Nominative), "четыреста" },
        { new KeyValuePair<int, Cases>(400, Cases.Genitive), "четырёхсот" },
        { new KeyValuePair<int, Cases>(400, Cases.Dative), "четырёмстам" },
        { new KeyValuePair<int, Cases>(400, Cases.Accusative), "четыреста" },
        { new KeyValuePair<int, Cases>(400, Cases.Instrumental), "четырьмястами" },
        { new KeyValuePair<int, Cases>(400, Cases.Prepositional), "четырёхстах" },
        
        // 500
        { new KeyValuePair<int, Cases>(500, Cases.Nominative), "пятьсот" },
        { new KeyValuePair<int, Cases>(500, Cases.Genitive), "пятисот" },
        { new KeyValuePair<int, Cases>(500, Cases.Dative), "пятистам" },
        { new KeyValuePair<int, Cases>(500, Cases.Accusative), "пятьсот" },
        { new KeyValuePair<int, Cases>(500, Cases.Instrumental), "пятьюстами" },
        { new KeyValuePair<int, Cases>(500, Cases.Prepositional), "пятистах" },
        
        // 600
        { new KeyValuePair<int, Cases>(600, Cases.Nominative), "шестьсот" },
        { new KeyValuePair<int, Cases>(600, Cases.Genitive), "шестисот" },
        { new KeyValuePair<int, Cases>(600, Cases.Dative), "шестистам" },
        { new KeyValuePair<int, Cases>(600, Cases.Accusative), "шестьсот" },
        { new KeyValuePair<int, Cases>(600, Cases.Instrumental), "шестьюстами" },
        { new KeyValuePair<int, Cases>(600, Cases.Prepositional), "шестистах" },
        
        // 700
        { new KeyValuePair<int, Cases>(700, Cases.Nominative), "семьсот" },
        { new KeyValuePair<int, Cases>(700, Cases.Genitive), "семисот" },
        { new KeyValuePair<int, Cases>(700, Cases.Dative), "семистам" },
        { new KeyValuePair<int, Cases>(700, Cases.Accusative), "семьсот" },
        { new KeyValuePair<int, Cases>(700, Cases.Instrumental), "семьюстами" },
        { new KeyValuePair<int, Cases>(700, Cases.Prepositional), "семистах" },
        
        // 800
        { new KeyValuePair<int, Cases>(800, Cases.Nominative), "восемьсот" },
        { new KeyValuePair<int, Cases>(800, Cases.Genitive), "восьмисот" },
        { new KeyValuePair<int, Cases>(800, Cases.Dative), "восьмистам" },
        { new KeyValuePair<int, Cases>(800, Cases.Accusative), "восемьсот" },
        { new KeyValuePair<int, Cases>(800, Cases.Instrumental), "восемьюстами" },
        { new KeyValuePair<int, Cases>(800, Cases.Prepositional), "восьмистах" },
        
        // 900
        { new KeyValuePair<int, Cases>(900, Cases.Nominative), "девятьсот" },
        { new KeyValuePair<int, Cases>(900, Cases.Genitive), "девятисот" },
        { new KeyValuePair<int, Cases>(900, Cases.Dative), "девятистам" },
        { new KeyValuePair<int, Cases>(900, Cases.Accusative), "девятьсот" },
        { new KeyValuePair<int, Cases>(900, Cases.Instrumental), "девятьюстами" },
        { new KeyValuePair<int, Cases>(900, Cases.Prepositional), "девятистах" },

    };
    
    
    public static string NumberToWord(int num, Cases @case, Genus genu) {
        if (num < 100 || num > 900 & num % 100 != 0) {
            throw new ArgumentOutOfRangeException();
        }

        if (_casesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)) {
            return numStr;
        }
        
        return string.Empty;
    }
}
