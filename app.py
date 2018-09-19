import datetime

def fibonacci(number):
    if number == 0: 
        return 0
    elif number == 1:
        return 1
    else:
        t1 = fibonacci(number - 1)
        t2 = fibonacci(number - 2)
        return t1 + t2

fibonacci(30) #warmup
for number in range(10, 45, 5):
    start = datetime.datetime.now()
    fibonacci(number)
    duration = datetime.datetime.now() - start
    print(number, "=>", (duration.days * 86400000) + (duration.seconds * 1000) + (duration.microseconds / 1000))