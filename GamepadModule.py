from ProductItemModule import ProductItem

class Gamepad(ProductItem):

    def __init__(self, dbId, art, nm, p, b):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        self.brand = b

    def get_info(self):
        return ProductItem.get_info(self) + ' Производитель: {}'.format(str(self.brand))