

with open('input.txt','r') as f:
    s = f.readline().strip()


result = 0
pos = 0
i = 0


while pos != -1:
    paren = s[i]
    pos += 1 if paren == '(' else -1 if paren == ')' else 0
    result += 1
    i += 1
        

print(result)


