from animals import Animals
from numbers import Numbers
from Fish import fishing

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info() 
    fishing = fishing()
    fishing.getFish()


if __name__ == "__main__":
	main()
