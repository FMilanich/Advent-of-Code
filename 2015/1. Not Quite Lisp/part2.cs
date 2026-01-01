
string s = File.ReadLines("input.txt").First();

int result = 0, pos = 0, i = 0;

while(pos != -1)
{
    char paren = s[i];

    if(paren == '(') pos++;
    else if(paren == ')') pos--;

    result++;
    i++;
}


Console.WriteLine(result);
