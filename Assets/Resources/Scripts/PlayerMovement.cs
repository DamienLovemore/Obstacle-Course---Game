using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    void Start()
    {
        
    }
        
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float moveVertical = Input.GetAxisRaw("Vertical") * moveSpeed;
        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical, Space.World);
    }
}
