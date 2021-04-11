extends Button


func _handle_button_pressed():
	GameManager.exit_game()


func _ready():
	if connect("pressed", self, "_handle_button_pressed") != OK:
		pass
