using Godot;

namespace ArngeJuice
{
    public class PlayerManager : Node
    {
        public Object? Player { get; set; }
        public PlayerInventory? PlayerInventory;

        public override void _Ready()
        {
            PlayerInventory = GetNode<PlayerInventory>("PlayerInventory");
        }
    }
}
