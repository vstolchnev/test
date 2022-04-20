import ProductItemModule
from Drill import Drill

ItemList = []

TestItem = ProductItemModule.ProductItem
MyItem = Drill
ItemList.append(TestItem(0,"0000","TestItem",0))
ItemList.append(MyItem(1, "0001", "Drill", 2000, 150))
for item in ItemList:
    print(item.get_info())