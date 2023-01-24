num = float(input("enter the number: "))
def remove_dot_from_float(n):
    while n % 10 != 0:
        n = round(n * 10, 7)
    return int(n // 10)
num_int = remove_dot_from_float(num)
def sum_digits(n):
    result = 0
    while n > 0:
        result += n % 10
        n //= 10
    return result
print(sum_digits(num_int))