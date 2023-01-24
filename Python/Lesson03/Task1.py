list = [2, 3, 5, 9, 3]
count = 0 
sum = 0 
for i in list:
    if count % 2 != 0: sum += i
    count += 1
print(f'{list}. Сумма нечетных чисел: {sum}')