from ProductItemModule import ProductItem

class Hairdryer(ProductItem):

    def __init__(self, dbId, art, nm, p, s):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        self.power = s

    def get_info(self):
        return ProductItem.get_info(self) + ' Мощность фена: {}'.format(str(self.power))