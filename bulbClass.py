from ProductItemModule import ProductItem
class bulb(ProductItem):
    color = "Тёплый"
    def glowing(self):
        print("Лампочка светится, свет ",self.color)
