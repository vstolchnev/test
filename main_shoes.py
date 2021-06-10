import random
class shoes():
    def __init__(self):
        self.name = ['Кроссовки','Мокасины','Туфли','Сандали']
        self.value = ['1','2','3','4']
        self.shoes_name = random.choice(self.name)
        self.shoes_value = random.choice(self.value)
    def get_shoes(self):
        print(f'В коллекции есть новые {self.shoes_name} в количестве: {self.shoes_value} пар(ы)')
        
shoess = shoes()
shoess.get_shoes()
