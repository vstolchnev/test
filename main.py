from animals import Animals
from number import Numbers
from Plants import Plants
from modems import Modem
from numbers import Numbers
from CarPark import CarPark
from Fish import fishing
from insects import Insects
from PlayingCards import Playing_Cards
from main_shoes import shoes

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
	fishing = fishing()
    fishing.getFish()
    bee = Insects('bee', true)
    bee.walk
	trump_card = Playing_Cards()
    trump_card.get_trump_card()
    shoes = shoes()
    shoes.get_shoes()
	
if __name__ == "__main__":
	main()