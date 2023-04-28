using TestTask.Solution.Enums;

namespace TestTask.Solution.Dictionaries; 

public static class TenNumberDictionary {
    
    /// <summary>
    /// Числа 20-90 по падежам
    /// </summary>
    private static Dictionary<KeyValuePair<int, Cases>, string> _casesNumDictionary = new() {
        // 20
        { new KeyValuePair<int, Cases>(20, Cases.Nominative), "двадцать" },
        { new KeyValuePair<int, Cases>(20, Cases.Genitive), "двадцати" },
        { new KeyValuePair<int, Cases>(20, Cases.Dative), "двадцати" },
        { new KeyValuePair<int, Cases>(20, Cases.Accusative), "двадцать" },
        { new KeyValuePair<int, Cases>(20, Cases.Instrumental), "двадцатью" },
        { new KeyValuePair<int, Cases>(20, Cases.Prepositional), "двадцати" },
        
        // 30
        { new KeyValuePair<int, Cases>(30, Cases.Nominative), "тридцать" },
        { new KeyValuePair<int, Cases>(30, Cases.Genitive), "тридцати" },
        { new KeyValuePair<int, Cases>(30, Cases.Dative), "тридцати" },
        { new KeyValuePair<int, Cases>(30, Cases.Accusative), "тридцать" },
        { new KeyValuePair<int, Cases>(30, Cases.Instrumental), "тридцатью" },
        { new KeyValuePair<int, Cases>(30, Cases.Prepositional), "тридцати" },
        
        // 40
        { new KeyValuePair<int, Cases>(40, Cases.Nominative), "сорок" },
        { new KeyValuePair<int, Cases>(40, Cases.Genitive), "сорока" },
        { new KeyValuePair<int, Cases>(40, Cases.Dative), "сорока" },
        { new KeyValuePair<int, Cases>(40, Cases.Accusative), "сорок" },
        { new KeyValuePair<int, Cases>(40, Cases.Instrumental), "сорока" },
        { new KeyValuePair<int, Cases>(40, Cases.Prepositional), "сорока" },
        
        // 50
        { new KeyValuePair<int, Cases>(50, Cases.Nominative), "пятьдесят" },
        { new KeyValuePair<int, Cases>(50, Cases.Genitive), "пятидесяти" },
        { new KeyValuePair<int, Cases>(50, Cases.Dative), "пятидесяти" },
        { new KeyValuePair<int, Cases>(50, Cases.Accusative), "пятьдесят" },
        { new KeyValuePair<int, Cases>(50, Cases.Instrumental), "пятьюдесятью" },
        { new KeyValuePair<int, Cases>(50, Cases.Prepositional), "шестидесяти" },
        
        // 60
        { new KeyValuePair<int, Cases>(60, Cases.Nominative), "шестьдесят" },
        { new KeyValuePair<int, Cases>(60, Cases.Genitive), "шестидесяти" },
        { new KeyValuePair<int, Cases>(60, Cases.Dative), "шестидесяти" },
        { new KeyValuePair<int, Cases>(60, Cases.Accusative), "шестьдесят" },
        { new KeyValuePair<int, Cases>(60, Cases.Instrumental), "шестьюдесятью" },
        { new KeyValuePair<int, Cases>(60, Cases.Prepositional), "шестидесяти" },
        
        // 70
        { new KeyValuePair<int, Cases>(70, Cases.Nominative), "семьдесят" },
        { new KeyValuePair<int, Cases>(70, Cases.Genitive), "семидесяти" },
        { new KeyValuePair<int, Cases>(70, Cases.Dative), "семидесяти" },
        { new KeyValuePair<int, Cases>(70, Cases.Accusative), "семьдесят" },
        { new KeyValuePair<int, Cases>(70, Cases.Instrumental), "семьюдесятью" },
        { new KeyValuePair<int, Cases>(70, Cases.Prepositional), "семидесяти" },
        
        // 80
        { new KeyValuePair<int, Cases>(80, Cases.Nominative), "восемьдесят" },
        { new KeyValuePair<int, Cases>(80, Cases.Genitive), "восьмидесяти" },
        { new KeyValuePair<int, Cases>(80, Cases.Dative), "восьмидесяти" },
        { new KeyValuePair<int, Cases>(80, Cases.Accusative), "восемьдесят" },
        { new KeyValuePair<int, Cases>(80, Cases.Instrumental), "восемьюдесятью" },
        { new KeyValuePair<int, Cases>(80, Cases.Prepositional), "восьмидесяти" },
        
        // 90
        { new KeyValuePair<int, Cases>(90, Cases.Nominative), "девяносто" },
        { new KeyValuePair<int, Cases>(90, Cases.Genitive), "девяноста" },
        { new KeyValuePair<int, Cases>(90, Cases.Dative), "девяноста" },
        { new KeyValuePair<int, Cases>(90, Cases.Accusative), "девяносто" },
        { new KeyValuePair<int, Cases>(90, Cases.Instrumental), "девяноста" },
        { new KeyValuePair<int, Cases>(90, Cases.Prepositional), "девяноста" },
    };
    
    public static string NumberToWord(int num, Cases @case, Genus genu) {
        if (num < 20 || num > 90 & num % 10 != 0) {
            throw new ArgumentOutOfRangeException();
        }

        if (_casesNumDictionary.TryGetValue(new KeyValuePair<int, Cases>(num, @case), out var numStr)) {
            return numStr;
        }
        
        return string.Empty;
    }
}