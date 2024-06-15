using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOverTime : MonoBehaviour
{
    public float lifeTIme;


    void Start()
    {
       // Destroy(gameObject, lifeTIme);
    }

    void Update()
    {
        lifeTIme -= Time.deltaTime;
        if (lifeTIme <= 0)
        {
            Destroy(gameObject);

        }
    }
}
