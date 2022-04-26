import HairDryerModule
import PrinterModule

ItemList = []

HairDryer = HairDryerModule.Hairdryer
Printer = PrinterModule.Printer

ItemList.append(HairDryer(12, "a0012bc", "Hairdryer", 1500, 800))
ItemList.append(Printer(14, "PRNTRLSR300", "Laser Printer", 3300.0, 300))

for item in ItemList:
    print(item.get_info())