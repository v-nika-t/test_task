
string [] GetArray(bool askUser = false) {
    if(!askUser) {
        string[] family = {"mother", "father", "son", "daughter", "dog", "cat"};
        return family;
    } else {
        Console.WriteLine("Введите через запятую слова");
        string [] newWords = Console.ReadLine().Split(",");
        return newWords;
    }
    

}

string [] GetElementsByParams(string [] array, int countSymbols = 4) {
       string[] changedArray = new string[array.Length];
       int k = 0;
        for(int i = 0; i < array.Length; i++) {
            if(array[i].Length < countSymbols) {
                changedArray[k++] = array[i];  
            }
        }
    return changedArray;
}


void ShowArray(string [] array) {
        for(int i = 0; i < array.Length; i++) {
            if(!String.IsNullOrEmpty(array[i])) Console.WriteLine($"{array[i]}");
        }
}

ShowArray(GetElementsByParams(GetArray()));
ShowArray(GetElementsByParams(GetArray(true)));



