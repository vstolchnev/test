import GamepadModule

GamepadList = []

Gamepad = GamepadModule.Gamepad
GamepadList.append(Gamepad(101,"1672085","PlayStation DualSense белый",6999,"Sony"))
GamepadList.append(Gamepad(102,"4816390","PlayStation DualSense черный",5999,"Sony"))
GamepadList.append(Gamepad(103,"4816390","Microsoft Xbox WLC",9999,"Microsoft"))

for item in GamepadList:
    print(item.get_info())