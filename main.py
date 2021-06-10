from animals import Animals
from numbers import Numbers
from CarPark import CarPark
from number import Numbers

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
	car = CarPark(20, 50, 10)
	car.printInfoAboutCarPark()


if __name__ == "__main__":
	main()
