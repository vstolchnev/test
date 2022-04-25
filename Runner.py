import ProductItemModule
import HairDryerModule
import Mixer
ItemList = []

HairDryer = HairDryerModule.Hairdryer
Mixer = Mixer.Mixer
ItemList.append(HairDryer(12, "a0012bc", "Hairdryer", 1500, 800))
ItemList.append(Mixer(12, "a0012bc", "Mixer", 1500, 800))

for item in ItemList:
    print(item.get_info())