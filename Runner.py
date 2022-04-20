import ProductItemModule
import PhotoCameraModule
ItemList = []

TestItem = ProductItemModule.ProductItem
PhotoCamera = PhotoCameraModule.PhotoCamera

ItemList.append(TestItem(0, "0000", "TestItem", 0))
ItemList.append(PhotoCamera(7, "0007", "Camera", 1000, "mirrored", "4k"))

for item in ItemList:
    print(item.get_info())