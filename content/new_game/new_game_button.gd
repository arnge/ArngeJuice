extends Button


func handle_button_pressed():
	get_tree().change_scene_to(load("res://content/new_game/NewGame.tscn"))


func _ready():
	connect("pressed", self, "handle_button_pressed")
