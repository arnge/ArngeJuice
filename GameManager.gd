extends Node


func exit_game():
	get_tree().quit()


func _unhandled_input(event):
	if ! (event is InputEventKey):
		return

	if event.pressed && event.scancode == KEY_ESCAPE:
		if get_tree().change_scene("res://Content/TitleScreen/TitleScreen.tscn") != OK:
			pass
