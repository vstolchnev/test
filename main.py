from animals import Animals
from numbers import Numbers
from insects import Insects

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
    bee = Insects('bee', true)
    bee.walk


if __name__ == "__main__":
	main()
