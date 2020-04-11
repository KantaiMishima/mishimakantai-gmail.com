using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private GameObject playerStage;
    [SerializeField]
    private float angularVelocity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angular = - angularVelocity * Mathf.Sin(this.transform.localRotation.y);
        playerStage.transform.Rotate(new Vector3(0, angular, 0));
    }
}
