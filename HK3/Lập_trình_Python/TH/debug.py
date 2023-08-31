def binary_search(arr, low, high, x):
    # Check base case
    if high >= low:
 
        mid = (high + low) // 2
 
        # If element is present at the middle itself
        if arr[mid] == x:
            return mid
 
        # If element is smaller than mid, then it can only
        # be present in left subarray
        elif arr[mid] > x:
            return binary_search(arr, low, mid - 1, x)
 
        # Else the element can only be present in right subarray
        else:
            return binary_search(arr, mid + 1, high, x)
 
    else:
        # Element is not present in the array
        return -1

s = [2,7,11,15]
target =  int(input("Target = "))
result = []
for i in range(len(s)-1):
    x = target-s[i]
    y = binary_search(s, x, len(s)-1, x)
    if(y!=-1):
        result.append(x)
print(result)
