using Godot;

namespace ArngeJuice
{
    public class Launch : Node
    {
        public override void _Ready()
        {
            GetTree().ChangeScene("res://TitleScreen.tscn");
        }
    }
}
