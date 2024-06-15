using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float laserSpeed;
    public GameObject impact;
    public GameObject expImapct;

    public bool hurtPlayer;

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
        if (other.gameObject.tag == "Enemy")
        {
            FindObjectOfType<GameManager>().DropPowerUp(other.transform.position);
            Destroy(other.gameObject);
            Instantiate(expImapct, other.gameObject.transform.position, other.gameObject.transform.rotation);
        }
        if (other.gameObject.tag == "Player" && hurtPlayer)
        {
            Destroy(other.gameObject);
            Instantiate(expImapct, other.gameObject.transform.position, other.gameObject.transform.rotation);
        }
        if (other.CompareTag("Shield"))
        {
            other.gameObject.SetActive(false);
        }

        Destroy(gameObject);
        Instantiate(impact, transform.position, transform.rotation);
       
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

