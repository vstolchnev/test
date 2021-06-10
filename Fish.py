import random
class fishing():
    def __init__(self):
        self.fish = ["Сазана", "Карпа", "Щуку", "Линя", "Карася", "Судака", "Леща", "Краснопёрка"]
        self.caughtFish = []
    
    def getFish(self):
        n = random.choice(self.fish)
        if n == "Сазана" or n == "Карпа" or n == "Щуку":
            weight = random.randrange(1, 15)
        else:
            weight = random.randrange(1,5)
            
        print("Вы поймали " + n + " весом в " + str(weight) + "кг.")
        self.caughtFish.append([n, str(weight) + "кг."])
        
    def bucket(self):
        for j in range(len(self.caughtFish)):
            print(self.caughtFish[j])
            
            

