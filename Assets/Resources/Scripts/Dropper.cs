using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTime = 5f;
    private MeshRenderer objectRenderer;
    private Rigidbody objectRdBody;

    void Start()
    {
        //Store the references to the components
        objectRenderer = GetComponent<MeshRenderer>();
        objectRdBody = GetComponent<Rigidbody>();

        //Starts invisible and stopped in the sky
        objectRenderer.enabled = false;
        objectRdBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > dropTime)
        {
            //After the time has passed make it appear
            //and fall to the ground
            objectRenderer.enabled = true;
            objectRdBody.useGravity = true;
        }
    }
}
