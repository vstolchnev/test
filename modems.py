class Modem(object):
    
    def __init__(self, imp, pr, t):
        self.implementation = imp
        self.principleOfWork = pr
        self.networkTypeAndConnectionType = t
        
    def getinfo(self):
        return "Тип модема: "+ self.implementation + " "+ self.principleOfWork\
               + " " + self.networkTypeAndConnectionType

        