def MultiplicationOfNumbers (numbers):
    result = []
    for i in range(len(numbers) // 2):
        result.append(numbers[i] * numbers[((i + 1) * -1)])
    if len(numbers) % 2 != 0:
        result.append(numbers[len(numbers) // 2] ** 2)
    return result
list = [2, 3, 4, 5, 6]
print(MultiplicationOfNumbers(list))