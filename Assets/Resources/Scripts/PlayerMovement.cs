using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstruction();
    }
        
    void FixedUpdate()
    {
        MovePlayer();
    }

    private void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float moveVertical = Input.GetAxisRaw("Vertical") * moveSpeed;
        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical, Space.World);
    }
}
