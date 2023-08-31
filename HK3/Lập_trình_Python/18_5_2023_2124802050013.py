#1
for i in range(10, 201):
    if(i % 7 == 0 and i % 5 != 0):
        print(i, end=" ")

#2
import math
def check_snt(n):
    if(n < 2):  return False
    for i in range(2, int(math.sqrt(n)+1)):
        if n % i == 0:  return False
    return True
n = int(input("nhap n: "))
for i in range(1, n+1):
    if(check_snt(i)):   print(i, end=" ")

#3
n = input('nhap n: ')
if(n[::-1] == n):   print("n la so doi xung.")
else: print("n khong phai la so doi xung.")

#4
str1 = input("nhap chuoi thu nhat: ")
str2 = input("nhap chuoi thu hai: ")
if(len(str1) > len(str2)):  print(str1)
else: print(str2)