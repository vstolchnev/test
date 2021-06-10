from animals import Animals
class CarPark:
    __numberOfCarsInCategoryA = 0
    __numberOfCarsInCategoryB = 0
    __numberOfCarsInCategoryC = 0
    __carParkIsOpen = False
    
    def __init__(self, catA, catB, catC):
        self.__numberOfCarsInCategoryA = catA
        self.__numberOfCarsInCategoryB = catB
        self.__numberOfCarsInCategoryC = catC
        
    def printInfoAboutCarPark(self):
        # Is the park open or closed
        stateOfThePark = self.__getState(self.__carParkIsOpen)
    
        print("\nCar Park is " + stateOfThePark 
              + "\nNumber Of Cars In Category A = " + str(self.__numberOfCarsInCategoryA) 
              + "\nNumber Of Cars In Category B = " + str(self.__numberOfCarsInCategoryB)
              + "\nNumber Of Cars In Category C = " + str(self.__numberOfCarsInCategoryC))
        
    
    def setStateOfThePark(self, state):
        self.__carParkIsOpen = state
    
    def __getState(self, state):
        if (state):
            return "Open"
        return "Closed"

def getAnimalsArray():
    arr = [Animals("Жора", "Желтый", 32), Animals("Гена", "Черный", 15), Animals("Борис", "Красный", 10)]
    return arr
        
obj = CarPark(10, 40, 15)
obj.setStateOfThePark(True)
obj.printInfoAboutCarPark()