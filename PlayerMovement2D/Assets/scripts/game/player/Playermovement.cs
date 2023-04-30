using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour


{
    private Rigidbody2D rigidBody2D;
    private Vector2 movementInput;
    [SerializeField]
    private float speed = 2f;
    private int x = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidBody2D.velocity = movementInput * speed;
    }


    private void OnMove(InputValue input)
    {
       movementInput = input.Get<Vector2>();
    }

    
}
