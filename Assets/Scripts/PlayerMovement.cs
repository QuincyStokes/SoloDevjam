using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Rigidbody2D rb;
    private Vector2 moveInput;


    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void OnMoveCancel(InputAction.CallbackContext context)
    {
        moveInput = Vector2.zero;
    }

    void FixedUpdate()
    {
        rb.velocity = moveInput * moveSpeed;
    }

}
