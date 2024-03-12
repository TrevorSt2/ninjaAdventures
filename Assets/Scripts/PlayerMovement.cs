using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5;
    [SerializeField] Vector2 movementDirection;
    PlayerAnimations animations;
    PlayerData playerData;



    Rigidbody2D rb;
    PlayerActions actions;
    Animator anim;

    private void Awake()
    {
        actions = new PlayerActions();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        animations = GetComponent<PlayerAnimations>();
        playerData = GetComponent<PlayerData>();
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
        if (movementDirection == Vector2.zero ) {
            animations.handleMoveBooolAnimation(false);
            return;
        }
        animations.handleMoveBooolAnimation(true);
        animations.handleMovingAnimation(movementDirection);
    }

    void Move()
    {
        if (playerData.PlayerStats.CurrentHealth <= 0) {
            return;
        }

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
