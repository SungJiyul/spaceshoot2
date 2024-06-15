using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public int what;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * movespeed * 0.005f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && what == 0)
        {
            collision.gameObject.GetComponent<PlayerController>().sheld.SetActive(true);
            Destroy(gameObject);
        }
        if (collision.tag == "Player" && what == 1)
        {
            collision.gameObject.GetComponent<PlayerController>().speedup();
            Destroy(gameObject);
        }
        if (collision.tag == "Player" && what == 2)
        {
            collision.gameObject.GetComponent<PlayerController>().morefire();
            Destroy(gameObject);
        }
    }
}
