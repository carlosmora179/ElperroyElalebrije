using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnMiedo : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRatio = 2f;
    public int enemyNumber = 0;
    private float timer =0f;
    float numAleat = 4f;
    System.Random random ;
    [SerializeField]
    FearBar barra;

    [SerializeField] private Transform pfMiedo;
   private void Start() {
       random = new System.Random();
   }
    void Update()
    {

        if(timer <= spawnRatio)
        {
            timer += Time.deltaTime;
        }
        
        else
        {
            timer = 0f;
            
            if(barra.slider.value <= 10 && barra.slider.value >= 7)
            {
                spawnRatio = 2;
                enemyNumber -= 1;
                numAleat = random.Next(4,11);
                pfMiedo.GetComponent<MiedoIA>().SetSpeed(numAleat);

                Instantiate(pfMiedo,transform.position,Quaternion.identity);
            }
            if(barra.slider.value < 7 && barra.slider.value >= 4)
            {
                spawnRatio = 4;
                enemyNumber += 1;
                numAleat = random.Next(4,11);
                pfMiedo.GetComponent<MiedoIA>().SetSpeed(numAleat);

                Instantiate(pfMiedo,transform.position,Quaternion.identity);
            }
            if(barra.slider.value < 4 && barra.slider.value >= 1)
            {
                spawnRatio = 6;
                enemyNumber += 1;
                numAleat = random.Next(4,11);
                pfMiedo.GetComponent<MiedoIA>().SetSpeed(numAleat);

                Instantiate(pfMiedo,transform.position,Quaternion.identity);
            }
        }
    }
}
