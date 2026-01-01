
string s = File.ReadLines("input.txt").First();
int result = 0;

foreach(char paren in s)
{
    if (paren == '(') result++;
    else if (paren == ')') result--;
}


Console.WriteLine(result);
