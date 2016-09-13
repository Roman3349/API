#include <iostream>
#include <stdint.h>

int main(int argc, char *argv[]);
uint64_t fibonacci(uint16_t n);

/**
 * Tato funkce vypočítá Fibonacciho číslo
 * @param n Číslo, ze kterého chceme vypočítat Fibonacciho čslo
 * @return Fibonacciho číslo
 */
uint64_t fibonacci(uint16_t n) {
	if (n < 2) {
		return(n);
	} else {
		return(fibonacci(n - 1) + fibonacci(n - 2));
	}
}

int main(int argc, char *argv[]) {
	uint16_t cislo;
	std::cout << "Zadejte číslo, ze kterého chcete vypočítat Fibonacciho číslo: ";
	std::cin >> cislo;
	std::cout << "Fibonacciho číslo ze čísla " << cislo << " je " << fibonacci(cislo) << "." << std::endl;
	return 0;
}
