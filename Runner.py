import HairDryerModule
ItemList = []

HairDryer = HairDryerModule.Hairdryer

ItemList.append(HairDryer(12, "a0012bc", "Hairdryer", 1500, 800))

for item in ItemList:
    print(item.get_info())