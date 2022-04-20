from ProductItemModule import ProductItem


class Drill(ProductItem):
    dbId = 1
    artikul = "0001"
    name = "Drill"
    price = 100.00
    speed = 150

    def __init__(self, dbId, art, nm, p, s):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        self.speed = s

    def set_price(self, dbId, price):
        pass

    def get_info(self):
        return 'Номер: {}. Арт: {}. Название: {}. Цена: {} Скорость: {}'.format(str(self.dbId),
                                                                                str(self.artikul),
                                                                                str(self.name),
                                                                                str(self.price),
                                                                                str(self.speed))
