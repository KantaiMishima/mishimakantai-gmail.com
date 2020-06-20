using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] int initialHP = 100;
    [SerializeField] Slider HPBar;
    // Start is called before the first frame update
    void Start()
    {
        HPBar.maxValue = initialHP;
        HPBar.value = initialHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage() {
        HPBar.value--;
        if (HPBar.value <= 0) {
            SceneManager.LoadScene("gameClear");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") {
            this.Damage();
            Destroy(other.gameObject);
        }
    }
}
