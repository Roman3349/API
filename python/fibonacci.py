def fibonacci(n):
	"""
	Tato funkce vypočítá Fibonacciho číslo
	@param n Číslo, ze kterého chceme vypočítat Fibonacciho čslo
	@return Fibonacciho číslo
	"""
	if (n < 2):
		return(n)
	else:
		return(fibonacci(n - 1) + fibonacci(n - 2))

while True:
	cislo = int(input("Zadejte číslo, ze kterého chcete vypočítat Fibonacciho číslo: "))
	print(fibonacci(cislo))
    
