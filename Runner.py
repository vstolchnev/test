import importlib
import glob
import os

main_module_name = 'ProductItemModule'
module_name = 'ProductModule'
current_modle_dir = os.path.join(os.path.dirname(os.path.abspath(__file__)), module_name) 

for file in glob.glob(current_modle_dir + "/*.py"):
    name = os.path.splitext(os.path.basename(file))[0]

    if name != main_module_name:
        module = importlib.import_module(module_name + '.' + name)
        model = getattr(module, name)
        print('\nModel: ' + name)
        model().get_info()
