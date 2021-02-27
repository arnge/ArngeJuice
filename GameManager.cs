using Godot;

namespace ArngeJuice
{
    public class GameManager : Node
    {
        public void ExitGame()
        {
            GetTree().Quit();
        }

        public override void _UnhandledInput(InputEvent inputEvent)
        {
            if (!(inputEvent is InputEventKey eventKey)) return;

            if (eventKey.Pressed && eventKey.Scancode == (int) KeyList.Escape)
                GetTree().ChangeScene("res://TitleScreen.tscn");
        }
    }
}