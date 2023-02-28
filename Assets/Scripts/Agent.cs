using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class Agent : MonoBehaviour
{
    public UnityEvent<Vector2> OnMoveBody = new UnityEvent<Vector2>();
    private Vector2 pointerInput, movementInput;

    public Vector2 PointerInput { get => pointerInput; set => pointerInput = value; }
    public Vector2 MovementInput { get => movementInput; set => movementInput = value; }

    // Update is called once per frame
    void Update()
    {
        GetBodyMovement();
    }
    private void GetBodyMovement()
    {
        //Debug.Log(movementVector);
        OnMoveBody?.Invoke(MovementInput);
    }
}
