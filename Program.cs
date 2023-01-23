
string[] family = {"mother", "father", "son", "daughter", "dog", "cat"};

string [] GetElementsByParams(string [] array, int countSymbols = 4) {
       string[] changedArray = new string[array.Length];
       int k = 0;
        for(int i = 0; i < family.Length; i++) {
            if(array[i].Length < countSymbols) {
                changedArray[k++] = family[i];  
            }
        }
    return changedArray;
}


void ShowArray(string [] array) {
        for(int i = 0; i < array.Length; i++) {
            if(!String.IsNullOrEmpty(array[i])) Console.WriteLine($"{array[i]}");
        }
}

ShowArray(GetElementsByParams(family));
