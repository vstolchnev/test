import ProductItemModule
from bulbClass import bulb

ItemList = []

TestItem = ProductItemModule.ProductItem
blb = bulb(3,"Свет","Лампочка",350)

ItemList.append(TestItem(0,"0000","TestItem",0))
ItemList.append(blb)
for item in ItemList:
    print(item.get_info())
    blb.glowing()
