from ProductItemModule import ProductItem

class Mixer(ProductItem):
	dbId = 2
	artikul = "Mixer1"
	name = "MyMixer"
	price = 200.00
	aroundspeed = 150
	weight = 2.5
	number_of_nozzles = 2
	
	def get_info(self):
		ProductItem.getInfo()
		print("Mixer" + " Aroundspee" + self.speed + " weigth" + self.weight + " Number of nozzles" + self.number_of_nozzles)
