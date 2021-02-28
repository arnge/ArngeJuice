using Godot;
using System;
using System.Linq;
using Godot.Collections;
using Directory = System.IO.Directory;

namespace ArngeJuice
{
    public class ContentManager : Node
    {
        private Node? _contentNode;

        public Array<NodePath> TitleScreenButtons { get; } = new();

        public void AddTitleScreenButton(NodePath scenePath)
        {
            TitleScreenButtons.Add(scenePath);
        }

        private void AddContent(Node child)
        {
            _contentNode?.AddChild(child);
        }

        private void LoadLocalContent()
        {
            var contentPath = ProjectSettings.GlobalizePath("res://Content");
            var directory = Directory.CreateDirectory(contentPath);
            foreach (var dir in directory.EnumerateDirectories())
            {
                var configFile = new ConfigFile();

                try
                {
                    configFile.Load(dir.GetFiles().Single(info => info.Name.Equals("content.cfg")).FullName);
                    var scriptPath = configFile.GetValue("content", "script", "").ToString();
                    var scriptFilePath = $"res://Content/{dir.Name}/{scriptPath}";
                    var script = GD.Load(scriptFilePath);
                    var contentId = Guid.NewGuid().ToString();
                    var node = new Node { Name = dir.Name };
                    node.Set("ContentId", contentId);
                    var nodeId = node.GetInstanceId();

                    node.SetScript(script);
                    node = (Node)GD.InstanceFromId(nodeId);

                    AddContent(node);
                }
                catch
                {
                    // ignored
                }
            }
        }

        public override void _Ready()
        {
            _contentNode = GetNode<Node>("Content");

            LoadLocalContent();
        }
    }
}
