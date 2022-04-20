from ProductItemModule import ProductItem


class Drill(ProductItem):
    dbId = 1
    artikul = "drill1"
    name = "myDrill"
    price = 100.00
    speed = 150
    weight = 2

    def getInfo(self):
        ProductItem.getInfo()
        print("Drill speed" + self.speed + " weigth" + self.weight)