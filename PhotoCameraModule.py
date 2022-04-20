from ProductItemModule import ProductItem

class PhotoCamera(ProductItem):

    def __init__(self, dbId, art, nm, p, tc, vq):
        self.dbId = dbId
        self.artikul = art
        self.name = nm
        self.price = p
        self.typeCam = tc
        self.VideoQuality = vq

    def get_info(self):
        return ProductItem.get_info(self) + ' Тип камеры: {}. Качество видео: {}'.format(str(self.typeCam), str(self.VideoQuality))


