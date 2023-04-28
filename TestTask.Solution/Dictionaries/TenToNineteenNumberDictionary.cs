using TestTask.Solution.Enums;

namespace TestTask.Solution.Dictionaries; 

public static class TenToNineteenNumberDictionary {

    /// <summary>
    /// Числа 10-19 по падежам
    /// </summary>
    private static Dictionary<KeyValuePair<int, Cases>, string> _casesNumDictionary = new() {
        // 10
        { new KeyValuePair<int, Cases>(10, Cases.Nominative), "десять" },
        { new KeyValuePair<int, Cases>(10, Cases.Genitive), "десяти" },
        { new KeyValuePair<int, Cases>(10, Cases.Dative), "десяти" },
        { new KeyValuePair<int, Cases>(10, Cases.Accusative), "десять" },
        { new KeyValuePair<int, Cases>(10, Cases.Instrumental), "десятью" },
        { new KeyValuePair<int, Cases>(10, Cases.Prepositional), "десяти" },
        
        // 11
        { new KeyValuePair<int, Cases>(11, Cases.Nominative), "одиннадцать" },
        { new KeyValuePair<int, Cases>(11, Cases.Genitive), "одиннадцати" },
        { new KeyValuePair<int, Cases>(11, Cases.Dative), "одиннадцати" },
        { new KeyValuePair<int, Cases>(11, Cases.Accusative), "одиннадцать" },
        { new KeyValuePair<int, Cases>(11, Cases.Instrumental), "одиннадцатью" },
        { new KeyValuePair<int, Cases>(11, Cases.Prepositional), "одиннадцати" },
        
        // 12
        { new KeyValuePair<int, Cases>(12, Cases.Nominative), "двенадцать" },
        { new KeyValuePair<int, Cases>(12, Cases.Genitive), "двенадцати" },
        { new KeyValuePair<int, Cases>(12, Cases.Dative), "двенадцати" },
        { new KeyValuePair<int, Cases>(12, Cases.Accusative), "двенадцать" },
        { new KeyValuePair<int, Cases>(12, Cases.Instrumental), "двенадцатью" },
        { new KeyValuePair<int, Cases>(12, Cases.Prepositional), "двенадцати" },
        
        // 13
        { new KeyValuePair<int, Cases>(13, Cases.Nominative), "тринадцать" },
        { new KeyValuePair<int, Cases>(13, Cases.Genitive), "тринадцати" },
        { new KeyValuePair<int, Cases>(13, Cases.Dative), "тринадцати" },
        { new KeyValuePair<int, Cases>(13, Cases.Accusative), "тринадцать" },
        { new KeyValuePair<int, Cases>(13, Cases.Instrumental), "тринадцатью" },
        { new KeyValuePair<int, Cases>(13, Cases.Prepositional), "тринадцати" },
        
        // 14
        { new KeyValuePair<int, Cases>(14, Cases.Nominative), "четырнадцать" },
        { new KeyValuePair<int, Cases>(14, Cases.Genitive), "четырнадцати" },
        { new KeyValuePair<int, Cases>(14, Cases.Dative), "четырнадцати" },
        { new KeyValuePair<int, Cases>(14, Cases.Accusative), "четырнадцать" },
        { new KeyValuePair<int, Cases>(14, Cases.Instrumental), "четырнадцатью" },
        { new KeyValuePair<int, Cases>(14, Cases.Prepositional), "четырнадцати" },
        
        // 15
        { new KeyValuePair<int, Cases>(15, Cases.Nominative), "пятнадцать" },
        { new KeyValuePair<int, Cases>(15, Cases.Genitive), "пятнадцати" },
        { new KeyValuePair<int, Cases>(15, Cases.Dative), "пятнадцати" },
        { new KeyValuePair<int, Cases>(15, Cases.Accusative), "пятнадцать" },
        { new KeyValuePair<int, Cases>(15, Cases.Instrumental), "пятнадцатью" },
        { new KeyValuePair<int, Cases>(15, Cases.Prepositional), "пятнадцати" },
        
        // 16
        { new KeyValuePair<int, Cases>(16, Cases.Nominative), "шестнадцать" },
        { new KeyValuePair<int, Cases>(16, Cases.Genitive), "шестнадцати" },
        { new KeyValuePair<int, Cases>(16, Cases.Dative), "шестнадцати" },
        { new KeyValuePair<int, Cases>(16, Cases.Accusative), "шестнадцать" },
        { new KeyValuePair<int, Cases>(16, Cases.Instrumental), "шестнадцатью" },
        { new KeyValuePair<int, Cases>(16, Cases.Prepositional), "шестнадцати" },
        
        // 17
        { new KeyValuePair<int, Cases>(17, Cases.Nominative), "семнадцать" },
        { new KeyValuePair<int, Cases>(17, Cases.Genitive), "семнадцати" },
        { new KeyValuePair<int, Cases>(17, Cases.Dative), "семнадцати" },
        { new KeyValuePair<int, Cases>(17, Cases.Accusative), "семнадцать" },
        { new KeyValuePair<int, Cases>(17, Cases.Instrumental), "семнадцатью" },
        { new KeyValuePair<int, Cases>(17, Cases.Prepositional), "семнадцати" },
        
        // 18
        { new KeyValuePair<int, Cases>(18, Cases.Nominative), "восемнадцать" },
        { new KeyValuePair<int, Cases>(18, Cases.Genitive), "восемнадцати" },
        { new KeyValuePair<int, Cases>(18, Cases.Dative), "восемнадцати" },
        { new KeyValuePair<int, Cases>(18, Cases.Accusative), "восемнадцать" },
        { new KeyValuePair<int, Cases>(18, Cases.Instrumental), "восемнадцатью" },
        { new KeyValuePair<int, Cases>(18, Cases.Prepositional), "восемнадцати" },
        
        // 19
        { new KeyValuePair<int, Cases>(19, Cases.Nominative), "девятнадцать" },
        { new KeyValuePair<int, Cases>(19, Cases.Genitive), "девятнадцати" },
        { new KeyValuePair<int, Cases>(19, Cases.Dative), "девятнадцати" },
        { new KeyValuePair<int, Cases>(19, Cases.Accusative), "девятнадцать" },
        { new KeyValuePair<int, Cases>(19, Cases.Instrumental), "девятнадцатью" },
        { new KeyValuePair<int, Cases>(19, Cases.Prepositional), "девятнадцати" },
    };
    
    
    public static string NumberToWord(int num, Cases @case, Genus genu) {
        if (num < 10 || num > 19) {
            throw new ArgumentOutOfRangeException();
        }

        if (_casesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)) {
            return numStr;
        }
        
        return string.Empty;
    }
}