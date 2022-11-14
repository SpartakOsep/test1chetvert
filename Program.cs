string[] arrayone = new string[7] { "hello", "2", "world", "1234", "1567", "-2", "computer science"};
string[] arraytwo = new string[arrayone.Length];
void ArrayWith(string[] arrayone, string[] arraytwo)
{
    int count = 0;
    for (int i = 0; i < arrayone.Length; i++)
    {
        if (arrayone[i].Length <= 3)
        {
            arraytwo[count] = arrayone[i];
            count++;
        }
    }
}
