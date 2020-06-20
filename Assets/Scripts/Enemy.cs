using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] int initialHP = 100;
    int HP = 100;
    // Start is called before the first frame update
    void Start()
    {
        HP = initialHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") {
            HP--;
            Destroy(other.gameObject);
            if (HP <= 0) {
                SceneManager.LoadScene("gameClear");
            }
        }
    }
}
