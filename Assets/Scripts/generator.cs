using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    float timer = 1;
    public GameObject[] gm; 

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            float pos_x = Random.Range(-4.0f, 4.0f);
            int randomIndex;

            // %10 ihtimalle bomba %90 ihtimalle meyve
            int chance = Random.Range(1, 101);
            if (chance <= 10)
            {
                randomIndex = 9; 
            }
            else
            {
                randomIndex = Random.Range(0, 9); 
            }

            Instantiate(gm[randomIndex], new Vector3(pos_x, 6.0f, 0.1f), Quaternion.identity);
            timer = 0.8f; // yeni obje oluþturma süresi
        }
    }
}
