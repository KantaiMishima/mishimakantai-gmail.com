using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = speed * this.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Enemy") {
            Destroy(this.gameObject);
        }
    }
}
