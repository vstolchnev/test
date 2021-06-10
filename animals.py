class Animals:
    def __init__(self, animal_name, animal_color, animal_age):
        self.animal_name = animal_name
        self.animal_color = animal_color
        self.animal_age = animal_age

    def get_info(self):
        print(f'Класс: животные, имя животного: {self.animal_name}, '
              f'цвет животного: {self.animal_color}, возраст животного: {self.animal_age}.')
