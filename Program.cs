using static System.Console;

string[] array = Array1();
string[] result = Find(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] Find(string[] input, int n) {
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
int Count(string[] input, int n) {
    int count = 0;
    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }
    return count;
}
string[] Array1() {
    Write("Введите значения : ");
    return ReadLine().Split(" ");
}
