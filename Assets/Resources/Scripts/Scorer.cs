using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hit = 0;

    void OnCollisionEnter(Collision collision)
    {
        //The score should not increase if we already hitted this object, or if
        //we hit the ground (plane)
        if ((collision.collider.name != "Ground") && (collision.collider.tag != "Hit"))
        {
            //Increases the score
            this.hit++;           

            Debug.Log($"You've bumped into a thing this many times: {hit}");
        }       
    }
}
