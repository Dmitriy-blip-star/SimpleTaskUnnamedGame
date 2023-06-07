using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class InputManager : MonoBehaviour
    {
        public GameObject player;

        private IControllable controllablePlayer;

        private void Start()
        {
            controllablePlayer = player.GetComponent<IControllable>();
            if (controllablePlayer == null)
            {
                throw new NullReferenceException("Player does't have IControllable interface");
            }
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                controllablePlayer.Move();
            }
            if (Input.GetKey(KeyCode.A))
            {
                controllablePlayer.Rotate("left");
            }
            if (Input.GetKey(KeyCode.D))
            {
                controllablePlayer.Rotate("right");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                controllablePlayer.Jump();
            }
        }
    }
}