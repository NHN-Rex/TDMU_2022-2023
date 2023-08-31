#cau 1:
# lst = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]

# #a) tach lst thanh 2 lst con chan va le.
# lst_odd, lst_even = [], []
# # for i in lst:
# #     if(i % 2 == 0): lst_odd.append(i)
# #     else: lst_even.append(i)
# lst_odd = list(filter(lambda a:(a%2==0), lst))
# lst_even = list(filter(lambda a:(a%2!=0), lst))
# print(lst_odd, lst_even)

#cau 2:
# n = int(input('nhap n: '))

# def sumn(n):
#     if(n==1): return 1
#     return n+sumn(n-1)

# print(sumn(n))

#Cau 3:
# n = int(input('nhap n: '))
# def fibo(n):
#     if(n == 1 or n == 2): return 1
#     return fibo(n-1)+fibo(n-2)

# print(fibo(n))

#Cau 4:
# n = int(input('nhap n: '))
# def tong(n):
#     if(n == 0): return 1
#     return tong(n-1)+100
# print(tong(n))
