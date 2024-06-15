using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    
    public Transform tr;

    public GameObject misail;

    private float timer;
    public float delay;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            timer = 0;
            Instantiate(misail, tr.position, tr.rotation);
        }


    }
    
}
