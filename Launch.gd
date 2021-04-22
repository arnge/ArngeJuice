extends Node


func _ready():
	if get_tree().change_scene("res://Content/TitleScreen/TitleScreen.tscn") != OK:
		pass
