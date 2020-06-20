using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatling : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float deltaShootTime = 1f;
    float lastTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        lastTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastTime + deltaShootTime < Time.time) {
            Instantiate(Bullet, this.transform.position + new Vector3(0, -0.1f, 0), this.transform.rotation);
            lastTime = Time.time;
        }
    }
}
