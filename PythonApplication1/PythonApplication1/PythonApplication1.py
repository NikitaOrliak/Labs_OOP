sec = int(input())

min = 0
hours = 0
days = 0

while sec >= 60:
    min += 1
    sec -= 60

while min >= 60:
    hours += 1
    min -= 60

while hours >= 24:
    days += 1
    hours -= 24

print ("days: ", days, "hours:", hours, "min: ", min, "sec: ", sec)