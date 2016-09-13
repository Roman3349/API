def factorial(n):
	"""
	Tato funkce vypočítá faktoriál
	@param n Číslo, ze kterého chceme vypočítat faktoriál
	@return Faktoriál daného čísla
	"""
	if (n <= 1):
		return(1)
	else:
		return(n * factorial(n - 1))

while True:
	cislo = int(input("Zadejte číslo, ze kterého chcete vypočítat Faktoriál: "))
	print(factorial(cislo))
