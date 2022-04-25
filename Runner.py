import ProductItemModule
import Mixer
ItemList = []

TestItem = ProductItemModule.ProductItem
Mixer = Mixer.Mixer
ItemList.append(TestItem(0,"0000","TestItem",0))
ItemList.append(Mixer(12, "a0012bc", "Mixer", 1500, 800))

for item in ItemList:
    print(item.get_info())