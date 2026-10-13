
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PrototypePlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float gravity = -9.81f;

    private CharacterController controller;
    private float verticalVelocity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Keyboard.current == null)
            return;

        Vector2 input = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) input.y += 1f;
        if (Keyboard.current.sKey.isPressed) input.y -= 1f;
        if (Keyboard.current.aKey.isPressed) input.x -= 1f;
        if (Keyboard.current.dKey.isPressed) input.x += 1f;

        Vector3 direction = new Vector3(input.x, 0f, input.y);
        direction = Vector3.ClampMagnitude(direction, 1f);

        if (controller.isGrounded && verticalVelocity < 0f)
            verticalVelocity = -2f;

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 velocity =
            direction * moveSpeed +
            Vector3.up * verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }
}
