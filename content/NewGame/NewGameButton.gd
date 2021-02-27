extends Button


func handle_button_pressed():
	if get_tree().change_scene_to(load("res://content/NewGame/NewGame.tscn")) != OK:
		pass


func _ready():
	if connect("pressed", self, "handle_button_pressed") != OK:
		pass
