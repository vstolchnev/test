from animals import Animals
from numbers import Numbers
from shoes import Shoes

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()


if __name__ == "__main__":
	main()
