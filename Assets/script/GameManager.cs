using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public Transform waveSpanwPoint;
    public GameObject[] waves;
    public float[] waveDelays;
    public bool spawningWave;
    private int waveTracker;
    //private float a;
    //private bool b = true;
    public float[] waveSave;

    public GameObject[] powerups;
    public int powerchance;

    void Start()
    {
        //waveSave = (float[])waveDelays.Clone();


        for (int i = 0; i < waveDelays.Length; i++)
        {
            waveSave[i] = waveDelays[i];

        }


    }


    // Update is called once per frame
    void Update()
    {
        if (spawningWave)
        {
            /*if (b)
            {
                a = waveDelays[waveTracker];
                b = false;

            }*/


            waveDelays[waveTracker] -= Time.deltaTime;
            if (waveDelays[waveTracker] < 0)
            {
                //waveDelays[waveTracker] = a;


                Instantiate(waves[waveTracker], waveSpanwPoint.position, waveSpanwPoint.rotation);

                waveTracker++;
                //b = true;
                if (waveTracker >= waveDelays.Length)
                {
                    //waveDelays = (float[])waveSave.Clone();
                    for (int i = 0; i < waveSave.Length; i++)
                    {
                        waveDelays[i] = waveSave[i];
                    }
                    waveTracker = 0;
                    //spawningWave = false;
                }
            }
        }

    }

    public void DropPowerUp(Vector3 enemyposition)
    {
        if(Random.Range(0, 100) < powerchance)
        {
            Instantiate(powerups[Random.Range(0, powerups.Length)], enemyposition, new Quaternion(0,0,0,0));
        }
    }
}
