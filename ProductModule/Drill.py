from .ProductItemModule import ProductItem

class Drill(ProductItem):
    def __init__(self):
        self.dbId = 1
        self.artikul = "0001"
        self.name = "Drill"
        self.price = 100.00
        self.speed = 150