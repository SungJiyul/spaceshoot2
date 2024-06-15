using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public GameObject boom;

    void Start()
    {

    }

    void Update()
    {
    

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shield"))
        {
            other.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
       if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Instantiate(boom, other.gameObject.transform.position,other.gameObject.transform.rotation);
        }
        
    }

}
