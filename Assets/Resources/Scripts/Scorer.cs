using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hit = 0;

    void OnCollisionEnter(Collision collision)
    {
        hit++;
        Debug.Log($"You've bumped into a thing this many times: {hit}");
    }
}
