using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("HIT");
            gm.gameOver();
        }

        if (other.CompareTag("Coin"))
        {
            Debug.Log("COIN");
            Destroy(other.gameObject);
            gm.addScore();
        }

        if (other.CompareTag("Win Object") && gm.key > 0)
        {
            Debug.Log("WIN");
            gm.victory();
        }
        
        if (other.CompareTag("Key"))
        {
            Debug.Log("KEY");
            Destroy(other.gameObject);
            gm.addKey();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
