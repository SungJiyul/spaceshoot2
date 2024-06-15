using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class BasicMove : MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedY;

    private Rigidbody2D rb;

    public float rotateSpeed;

    //private float ttime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //ttime = 2;
    }

    void Update()
    {

        /* ttime += Time.deltaTime;
         if (ttime >= 2)
         {
             ttime = 0;
             moveSpeedY = Random.Range(-2, 2);
         }

       */
        rb.velocity = new Vector2(moveSpeedX, moveSpeedY);

        

        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z + (Random.Range(rotateSpeed / 100f, rotateSpeed) * Time.deltaTime));


    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
