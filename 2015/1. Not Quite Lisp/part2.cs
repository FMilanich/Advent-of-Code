
string s = File.ReadLines("input.txt").First();

int result = 0;
int pos = 0;
int i = 0;

while(pos != -1)
{
    char paren = s[i];

    if(paren == '(') pos++;
    else pos--;

    result++;
    i++;
}


Console.WriteLine(result);
