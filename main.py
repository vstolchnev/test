from animals import Animals
from number import Numbers
from Plants import Plants
from modems import Modem
from numbers import Numbers
from CarPark import CarPark


def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
	plants = Plants()
	plants.writing
	car = CarPark(20, 50, 10)
	car.printInfoAboutCarPark()
	modem1 = Modem('внутренний', 'аппаратный', 'powerline')
	print(modem1.getinfo())

	
if __name__ == "__main__":
	main()

