import ProductItemModule
import PhotoCameraModule
ItemList = []

TestItem = ProductItemModule.ProductItem
PhotoCamera = PhotoCameraModule.PhotoCamera

ItemList.append(TestItem(0, "0000", "TestItem", 0))
ItemList.append(PhotoCamera(0, "0000", "TestItem", 1000, "dd", "dd"))

for item in ItemList:
    print(item.get_info())