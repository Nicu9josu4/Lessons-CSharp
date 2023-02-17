def sum_array(arr):
    sum = 0
    for num in arr:
        sum += num
    return sum

arr = [1, 2, 3, 4, 5]
result = sum_array(arr)
print("The sum of the array is:", result)