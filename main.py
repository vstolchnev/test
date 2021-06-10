from animals import Animals
from number import Numbers
from Plants import Plants
from modems import Modem

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
	plants = Plants()
	plants.writing
	modem1 = Modem('внутренний', 'аппаратный', 'powerline')
	print(modem1.getinfo())
    


if __name__ == "__main__":
	main()

