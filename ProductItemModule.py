from Drill import Drill


class ProductItem:
    dbId = 0
    artikul = "z0000qw"
    name = "Test"
    price = 100.00
    
    def __init__(self, dbId, art, nm, p):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        
    def set_price(self, dbId, price):
        pass

    def getInfo(self):
        print(self.artikul + " " + self.name + " price" + self.price)

if __name__ == '__main__':
    pr = ProductItem()
    drill = Drill()

    data = [pr, drill]

    for element in data:
        element.getInfo()