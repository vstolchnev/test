from ProductItemModule import ProductItem

class Printer(ProductItem):
    def __init__(self, dbId, art, nm, p, d):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        self.dpi = d

    def get_info(self):
        return ProductItem.get_info(self) + ' Разрешение принтера: {}'.format(str(self.dpi))