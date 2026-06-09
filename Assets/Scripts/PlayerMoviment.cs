using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D body;

    private void Awake() {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Keyboard.current.upArrowKey.isPressed) {
            moveY = 1f;
        }

        if (Keyboard.current.leftArrowKey.isPressed) {
            moveX = -1f;
        }

        if (Keyboard.current.rightArrowKey.isPressed) {
            moveX = 1f;
        }

        if (Keyboard.current.downArrowKey.isPressed) {
            moveY = -1f;
        }

        body.linearVelocity = new Vector2(moveX * speed, moveY * speed);
    }
}
