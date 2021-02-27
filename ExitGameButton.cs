using Godot;

namespace ArngeJuice
{
    public class ExitGameButton : Button
    {
        private GameManager? _gameManager;

        private void HandleButtonPressed()
        {
            _gameManager!.ExitGame();
        }

        public override void _Ready()
        {
            _gameManager = GetNode<GameManager>("/root/GameManager");
            Connect("pressed", this, nameof(HandleButtonPressed));
        }
    }
}
