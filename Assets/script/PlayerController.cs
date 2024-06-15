using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    public GameObject sheld;
    private Rigidbody2D rb;
    private Animator ani;
    

    public float speed;

    public Transform LT;
    public Transform RB;
    public GameObject bullet;
    public Transform bulletPoint1;
    public Transform bulletPoint2;
    public Transform bulletPoint3;
    public Transform bulletPoint4;
    public Transform bulletPoint5;


    float time = 0;
    public float dela;
    public float length;

    public int firelv = 1;

    
    public Vector2 moveInput;
    float time2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = moveInput * speed;
        //애니에 플룻값을 (무브먼트에 인풋 와이값을 적용함)
        ani.SetFloat("Movement", moveInput.y);

        //transform.position=new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, -4.5f, 4.5f),transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, LT.position.x, RB.position.x), Mathf.Clamp(transform.position.y, RB.position.y, LT.position.y), transform.position.z);


        time += Time.deltaTime;
        switch (firelv) {
            case 1:
                if (dela < time)
                 {
                     time = 0;
                    Instantiate(bullet, bulletPoint1.position, bulletPoint1.rotation);
                }
                break;
            case 2:
                if (dela < time)
                {
                    time = 0;
                    Instantiate(bullet, bulletPoint2.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint3.position, bulletPoint3.rotation);
                }
                break;
            case 3:
                if (dela < time)
                {
                    time = 0;
                    Instantiate(bullet, bulletPoint1.position, bulletPoint1.rotation);
                    Instantiate(bullet, bulletPoint2.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint3.position, bulletPoint3.rotation);
                }
                break;
            case 4:
                if (dela < time)
                {
                    time = 0;
                    Instantiate(bullet, bulletPoint4.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint5.position, bulletPoint3.rotation);
                    Instantiate(bullet, bulletPoint2.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint3.position, bulletPoint3.rotation);
                }
                break;
            case 5:
                if (dela < time)
                {
                    time = 0;
                    Instantiate(bullet, bulletPoint1.position, bulletPoint1.rotation);
                    Instantiate(bullet, bulletPoint2.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint3.position, bulletPoint3.rotation);
                    Instantiate(bullet, bulletPoint4.position, bulletPoint2.rotation);
                    Instantiate(bullet, bulletPoint5.position, bulletPoint3.rotation);
                }
                break;

        }    


         
        if (time2 > 0)
        {
            time2 -= Time.deltaTime;

        }
        if (time2 < 0.001f)
        {
            speed = 7;
            time2 = 0;
        }
    }

    public void speedup()
    {
        speed = 12;
        time2 = length;
    }

    public void morefire()
    {
        if (firelv != 5)
            firelv += 1;
    }

}
