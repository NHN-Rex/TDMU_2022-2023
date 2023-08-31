#2
n = int(input('nhap n: '))
#2a
print('So nguyen vua nhap la: ',n)
#2b
sum = 0
for i in range(1, n+1):
    sum += i
print('Tong cua n so nguyen dau tien la: ',sum)
#2c
gt = 1
for i in range(1, n+1):
    gt *= i
print('Gia tri cua n giai thua la: ',gt)

#3
a, b = int(input('nhap a: ')), int(input('nhap b: '))

#3a
print('Tong hai so a, b vua nhap la: ', a+b)
#3b
print('Hieu hai so a, b vua nhap la: ', a-b)
#3c
print('Tich hai so a, b vua nhap la: ', a*b)
#3d
print('Thuong hai so a, b vua nhap la: ', a/b)

#4
x = int(input('nhap x: '))
if x % 2 == 0:
    print(x, 'la so chan.')
else:
    print(x, 'la so le.')

#5
import math
a, b, c = int(input('nhap a: ')), int(input('nhap b: ')), int(input('nhap c: '))
delta = (b*b-4*a*c)
if(delta < 0):
    print('Phuong trinh vo nghiem.')
elif(delta == 0):
    print('Phuong trinh co nghiem kep x1 = x2 = ', (-b/(2*a)))
else:
    print('Phuong trinh co 2 nghiem phan biet x1 = ',(-b+math.sqrt(delta))/2*a, ' x2 = ', (-b - math.sqrt(delta))/2*a)

#6
dtb = int(input('nhap diem ren luyen: '))
if(dtb < 50):
    print('Yeu')
elif(dtb >= 50 and dtb < 60):
    print('Trung binh')
elif(dtb >= 60 and dtb < 70):
    print('Trung binh kha')
elif(dtb >= 70 and dtb < 80):
    print('Kha')
elif(dtb >= 80 and dtb < 90):
    print('Xep loai tot')
else:
    print('Xep loai xuat sac')
