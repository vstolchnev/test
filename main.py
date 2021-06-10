from animals import Animals
from numbers import Numbers
from main_shoes import shoes

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
    shoes = shoes()
    shoes.get_shoes()

if __name__ == "__main__":
	main()
