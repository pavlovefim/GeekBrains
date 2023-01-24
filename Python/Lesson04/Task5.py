with open('text_1.txt', 'w', encoding='utf-8') as file:
    file.write('2*x^2 + 5*x^5')
with open('text_2.txt', 'w', encoding='utf-8') as file:
    file.write('23*x^4 + 9*x^6')

with open('text_1.txt','r') as file:
    text_1 = file.readline()
    list_of_text_1 = text_1.split()


with open('text_2.txt','r') as file:
    text_2 = file.readline()
    list_of_text_2 = text_2.split()

print(f'{list_of_text_1} + {list_of_text_2}')
sum_text = list_of_text_1 + list_of_text_2

with open('sum_text.txt', 'w', encoding='utf-8') as file:
    file.write(f'{list_of_text_1} + {list_of_text_2}')