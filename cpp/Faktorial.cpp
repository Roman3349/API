#include <iostream>
#include <stdint.h>

int main(int argc, char *argv[]);
uint64_t faktorial(uint16_t n);

/**
 * Tato funkce vypočítá faktoriál
 * @param n Číslo, ze kterého chceme vypočítat faktoriál
 * @return Faktoriál daného čísla
 */
uint64_t faktorial(uint16_t n) {
	if (n <= 1) {
		return(1);
	} else {
		return(n * faktorial(n - 1));
	}
}

int main(int argc, char *argv[]) {
	uint16_t cislo;
	std::cout << "Zadejte číslo, ze kterého chcete vypočítat Faktoriál: ";
	std::cin >> cislo;
	std::cout << "Faktoriál ze čísla " << cislo << " je " << faktorial(cislo) << "." << std::endl;
	return 0;
}
