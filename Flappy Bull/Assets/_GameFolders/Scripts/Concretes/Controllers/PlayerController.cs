using System.Collections;
using System.Collections.Generic;
using FlappyBull.Combats;
using FlappyBull.Movements;
using UnityEngine;

namespace FlappyBull.Controllers
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
      
        private Rigidbody2D _rigidbody2D;

        PlayerJump _jump;
        DesktopInputController _desktopInputController;
        InstantiateProjectile _instantiateProjectile;
        DeadAction _deadAction;

        AudioSource _audioSource;
        private bool _isJumpButtonClicked;
        private bool _isFireButtonClicked;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<PlayerJump>();
            _instantiateProjectile = GetComponent<InstantiateProjectile>();
            _desktopInputController = new DesktopInputController();
            _audioSource = GetComponent<AudioSource>();
            _deadAction = GetComponent<DeadAction>();
        }

        private void Update()
        {
            if (_deadAction.IsDead) return;

            _isJumpButtonClicked = _desktopInputController.LeftMouseClickDown || _desktopInputController.SpaceButtonClickDown;//Inputs need to be defined in update
            _isFireButtonClicked = _desktopInputController.FButtonClickDown;//Inputs need to be defined in update
        }
        private void FixedUpdate()
        {
            if (_isJumpButtonClicked)
            {
                _jump.JumpAction(rigidbody2D: _rigidbody2D);//Physics need to be defined in FixedUpdate, because it is intgreated with game engine physics logic. Default time 0.2
                _audioSource.Play();

                _isJumpButtonClicked = false;
            }
            if (_isFireButtonClicked)
            {
                _instantiateProjectile.InstantiateFireAction();
                _isFireButtonClicked = false;
            }
        }

    }

}
