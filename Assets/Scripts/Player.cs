using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public float maxAngularVelocity = 1;
    public float maxVelocity = 10;
    public GameObject playerCamera;
    private Rigidbody preyerRb;

    private float PowTwo(float baseFloat)
    {
        return Mathf.Pow(baseFloat, 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        preyerRb = GetComponent<Rigidbody>();
        preyerRb.maxAngularVelocity = maxAngularVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        preyerRb.AddForce(playerCamera.transform.forward * 3);
        var vel = preyerRb.velocity;
        var magnification = (PowTwo(vel.x) + PowTwo(vel.y) + PowTwo(vel.z)) / maxVelocity;
        if (magnification > 1)
        {
            preyerRb.velocity = vel / magnification;
        }
    }
}
