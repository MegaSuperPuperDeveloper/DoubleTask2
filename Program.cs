// Вы, вероятно, знакомы с системой "нравится" на Facebook и других страницах. Люди могут "лайкать"
// записи в блоге, фотографии или другие элементы. Мы хотим создать текст, который должен 
// отображаться рядом с таким элементом. Реализуйте функцию, которая принимает массив, 
// содержащий имена людей, которым нравится элемент. Она должна возвращать отображаемый текст.

string[] PullArray(string[] array) {
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"Напишите {i + 1} имя для массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintMatrix(string[] array) {
    if(array.Length == 0) Console.WriteLine("no one likes this");
    else if(array.Length < 4){
        for(int i = 0; i < array.Length; i++) {
            if(i != array.Length - 1 && i != 0) Console.Write($", {array[i]}");
            else if(i == 0) Console.Write($"{array[i]}");
            else Console.Write($" and {array[i]}");
        }
        if(array.Length ==  1) Console.Write(" likes this");
        else Console.Write(" like this");
    } else if(array.Length >= 4) {
        for(int i = 0; i <= 2; i++) {
            if(i == 0)  Console.Write($"{array[i]}");
            else if(i > 0 && i < 2) Console.Write($", {array[i]}");
            else Console.Write($" and {array.Length - 2} others like this");
        }
    } else {
        for(int i = 0; i < 4; i++) {
            if(i != array.Length - 1 && i != 0) Console.Write($", {array[i]}");
            else if(i == 0) Console.Write($"{array[i]}");
            else Console.Write($" and 2 others like this");
        }
    }
}

var length = new Random().Next(0, 4);
if(length != 0) {
    string[] names = new string[4];
    PullArray(names);
    PrintMatrix(names);
}