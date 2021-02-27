using Godot;

namespace ArngeJuice
{
    public class TitleScreen : Control
    {
        private ContentManager? _contentManager;
        private VBoxContainer? _customButtonList;

        private void AddCustomButtons()
        {
            foreach (var titleScreenButtonScene in _contentManager?.TitleScreenButtons!)
            {
                var scene = GD.Load<PackedScene>(titleScreenButtonScene);
                var node = scene.Instance();
                _customButtonList?.AddChild(node);
            }
        }

        public override void _Ready()
        {
            _contentManager = GetNode<ContentManager>("/root/ContentManager");
            _customButtonList =
                GetNode<VBoxContainer>("MarginContainer/CenterContainer/TitleScreenButtons/CustomButtonList");
            AddCustomButtons();
        }
    }
}
