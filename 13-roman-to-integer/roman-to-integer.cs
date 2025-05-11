public class Solution {
    //Fahad
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        string input = s.ToUpper();

        foreach (char c in input) {
            if (!romanMap.ContainsKey(c)) {
                Console.WriteLine("Give valid number");
                throw new ArgumentException("Give valid number");
            }
        }

        int total = 0;

        for (int i = 0; i < input.Length; i++) {
            int value = romanMap[input[i]];
            if (i + 1 < input.Length && romanMap[input[i]] < romanMap[input[i + 1]]) {
                total -= value;
            } else {
                total += value;
            }
        }

        return total;
    }
}
