using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    readonly int moveX = Animator.StringToHash("moveX");
    readonly int moveY = Animator.StringToHash("moveY");
    readonly int isMoving = Animator.StringToHash("isMoving");
    readonly int gotKilled = Animator.StringToHash("gotKilled");
    readonly int revived = Animator.StringToHash("revived");

    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void handleDeadAnimation()
    {
        anim.SetTrigger(gotKilled);
    }

    public void handleMoveBooolAnimation(bool value)
    {
        anim.SetBool(isMoving, value);
    }

    public void handleMovingAnimation(Vector2 dir)
    {
        anim.SetFloat(moveX, dir.x);
        anim.SetFloat(moveY, dir.y);
    }
}
