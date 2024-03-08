using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5;
    [SerializeField] Vector2 movementDirection;


    Rigidbody2D rb;
    PlayerActions actions;

    private void Awake()
    {
        actions = new PlayerActions();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void onDisable()
    {
        actions.Disable(); ;
    }

    void ReadMovement()
    {
        movementDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
    }

    void Move()
    {
        rb.MovePosition((rb.position + movementDirection) * movementSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        ReadMovement();
    }

    private void Update()
    {
        Move();
    }
}
