using Godot;

namespace ArngeJuice
{
    public class SceneManager : Node
    {
        private NodePath ScenePath { get; set; } = new();

        [Signal]
        // ReSharper disable once InconsistentNaming
        public delegate void scene_changed(NodePath scenePath);

        private void HandleNodeAdded(Node node)
        {
            if (node.GetParent() != GetTree().Root) return;

            var path = node.GetPath();
            if (path == null || ScenePath == path) return;

            ScenePath = path;
            EmitSignal(nameof(scene_changed), path);
        }

        public override void _Ready()
        {
            GetTree().Connect("node_added", this, nameof(HandleNodeAdded));
        }
    }
}
