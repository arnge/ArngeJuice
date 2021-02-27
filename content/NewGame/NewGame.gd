extends Node


func _ready():
	"""
	Here is where we would do any brand new game shit,
	like launching into the character creator and whatnot
	"""

	# Once we're done with everything, go act 0!
	if get_tree().change_scene_to(load("res://content/act_0/Act0.tscn")) == OK:
		pass
