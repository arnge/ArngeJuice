using Godot;
using Godot.Collections;

namespace ArngeJuice
{
    public class PlayerInventory : Node
    {
        public Array<Object> InventoryItems { get; } = new();

        [Signal]
        public delegate void item_added(Object itemAdded);

        [Signal]
        public delegate void item_removed(Object itemRemoved);

        public void AddItem(Object item)
        {
            InventoryItems.Add(item);
            EmitSignal(nameof(item_added), item);
        }

        public void RemoveItem(Object item)
        {
            InventoryItems.Remove(item);
            EmitSignal(nameof(item_removed), item);
        }

        public override void _Ready()
        {
        }
    }
}
