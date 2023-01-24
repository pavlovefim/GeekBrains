x1= float(input("Введите координату первой точки по оси X: "))
y1= float(input("Введите координату первой точки по оси Y: "))
x2= float(input("Введите координату второй точки по оси X: "))
y2= float(input("Введите координату второй точки по оси Y: "))
import math
distance=round(math.sqrt((x2-x1)**2+(y2-y1)**2), 2)
print('Расстояние между точками: {}'.format(distance))