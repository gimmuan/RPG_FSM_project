using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public PlayerInputActions InputActions {  get; private set; }
    public PlayerInputActions.PlayerActions PlayerActions { get; private set; }

    public KeyCode key = KeyCode.R;

    private void Awake()
    {
        InputActions = new PlayerInputActions();
        PlayerActions = InputActions.Player;
    }
    private void OnEnable()
    {
        InputActions.Enable();
    }
    private void OnDisable()
    {
        InputActions.Disable();
    }

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            GetComponent<Player>().transform.position = Vector3.zero;
        }
    }
}
