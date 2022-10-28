using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //If the thing that collided with the wall, is the
        //player
        if (collision.collider.tag == "Player")
        {
            //Changes the wall color (the material is what hold the color)
            //(Uses Color32 instead of Color, because otherwise it will be
            //white for all light colors)
            GetComponent<MeshRenderer>().material.color = new Color32(244, 62, 62, 255);
        }
    }
}
