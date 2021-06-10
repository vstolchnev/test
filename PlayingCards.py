import random

class Playing_Cards():
    def __init__(self):
        self.suit = ['Черви', 'Крести', 'Буби', 'Пики']
        self.value = ['6', '7', '8', '9', '10', 'Валет', 'Дама', 'Король', 'Туз']
        self.card_suit = random.choice(self.suit)
        self.card_value = random.choice(self.value)
        
    def get_trump_card(self):
        print(f'Козырная карта: {self.card_value} {self.card_suit}')
        
trump_card = Playing_Cards()
trump_card.get_trump_card()
