using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    public float laserSpeed;
    public GameObject impact;

    //private Rigidbody2D rb;

    //Vector2 vec;

    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //rb.velocity = vec;
        //vec = new Vector2(laserSpeed, 0f);
        transform.position = new Vector3(transform.position.x + (laserSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        /*if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }*/

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Instantiate(impact, transform.position, transform.rotation);
        }
        Destroy(gameObject);
        
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

