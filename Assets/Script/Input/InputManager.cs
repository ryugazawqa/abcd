using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerInput playerInput;
    public static Vector2 Movement;
    public static bool jumpPressed;
    public static bool attackPressed;
    public static bool interactPressed; // E tu�u i�in eklendi

    private InputAction _moveAction;
    private InputAction _jumpAction;
    private InputAction attackAction;
    private InputAction interactAction; // E tu�u action'�

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        _moveAction = playerInput.actions["Move"];
        _jumpAction = playerInput.actions["Jump"];
        attackAction = playerInput.actions["Attack"];
        interactAction = playerInput.actions["Interact"]; // E tu�u action'�
    }

    private void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>();
        jumpPressed = _jumpAction.WasPressedThisFrame();
        attackPressed = attackAction.WasPressedThisFrame();
        interactPressed = interactAction.WasPressedThisFrame(); // E tu�u kontrol�
    }
}