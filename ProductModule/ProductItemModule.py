class ProductItem:
    def __init__(self):
        self.dbId = 0
        self.artikul = "z0000qw"
        self.name = "Test"
        self.price = 100.00

    def get_info(self):
        for k in self.__dict__:
                print(k + ' : ' + str(self.__dict__[k]))
