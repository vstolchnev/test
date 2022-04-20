import ProductItemModule

ItemList = []

TestItem = ProductItemModule.ProductItem

ItemList.append(TestItem(0,"0000","TestItem",0))

for item in ItemList:
    print(item.get_info())