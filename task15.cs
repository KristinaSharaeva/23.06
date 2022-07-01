Console.WriteLine("введите номер дня недели");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1) {
    Console.WriteLine ("Нет");
}
if (numberA == 2) {
    Console.WriteLine ("Нет");
}
if (numberA == 3) {
    Console.WriteLine ("Нет");
}
if (numberA == 4) {
    Console.WriteLine ("Нет");
}
if (numberA == 5) {
    Console.WriteLine ("Нет");
}
if (numberA == 6) {
    Console.WriteLine ("Да");
}
if (numberA == 7) {
    Console.WriteLine ("Да");
}
if (numberA > 7 || numberA < 1) {
    Console.WriteLine ("Ошибка");
}