using System;
using Godot;

namespace ArngeJuice
{
    public class Player : KinematicBody
    {
        public Ulid Id = Ulid.NewUlid();
        private PlayerManager? _playerManager;
        private SceneManager? _sceneManager;

        public override void _Ready()
        {
            _playerManager = GetNode<PlayerManager>("/root/PlayerManager");
            _sceneManager = GetNode<SceneManager>("/root/SceneManager");

            _playerManager.Player = this;
            GD.Print(Id);
        }

        public override void _PhysicsProcess(float delta)
        {
        }
    }
}
