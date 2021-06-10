from animals import Animals
from numbers import Numbers
from PlayingCards import Playing_Cards

def main():
	crocodile = Animals('крокодил', 'зеленый', '22')
	crocodile.get_info()
	num = Numbers()
	num.info()
    trump_card = Playing_Cards()
    trump_card.get_trump_card()

if __name__ == "__main__":
	main()
