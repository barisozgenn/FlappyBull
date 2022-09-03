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

        private bool _isJumpButtonClicked;
        private bool _isFireButtonClicked;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<PlayerJump>();
            _instantiateProjectile = GetComponent<InstantiateProjectile>();
            _desktopInputController = new DesktopInputController();
        }

        private void Update()
        {
            _isJumpButtonClicked = _desktopInputController.LeftMouseClickDown || _desktopInputController.SpaceButtonClickDown;//Inputs need to be defined in update
            _isFireButtonClicked = _desktopInputController.FButtonClickDown;//Inputs need to be defined in update
        }
        private void FixedUpdate()
        {
            if (_isJumpButtonClicked)
            {
                _jump.JumpAction(rigidbody2D: _rigidbody2D);//Physics need to be defined in FixedUpdate, because it is intgreated with game engine physics logic. Default time 0.2
                _isJumpButtonClicked = false;
            }
            if (_isFireButtonClicked)
            {
                _instantiateProjectile.InstantiateFireAction();
                _isFireButtonClicked = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("collision => " + collision.gameObject.name);

            if (collision.gameObject.tag == "Enemy")
            {
                GameManager.Instance.RestartGame();
            }
        }
    }

}
