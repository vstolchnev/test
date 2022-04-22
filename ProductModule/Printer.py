from .ProductItemModule import ProductItem

class Printer(ProductItem):
    def __init__(self):
        self.dbId = 14
        self.artikul = "PRNTRLSR300"
        self.name = "LaserPrinter"
        self.price = 250.00
        self.dpi = 300
