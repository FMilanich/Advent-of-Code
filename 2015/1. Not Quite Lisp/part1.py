

with open('input.txt','r') as f:
    s = f.readline().strip()


result = 0


for paren in s:
    result += 1 if paren == '(' else -1 if paren == ')' else 0

print(result)


