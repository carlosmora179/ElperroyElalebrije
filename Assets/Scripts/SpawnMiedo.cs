using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnMiedo : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRatio = 2f;
    public int enemyNumber = 10;
    private float timer =0f;
    float numAleat = 4f;
    System.Random random ;

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
            
            if(enemyNumber > 0)
            {
                enemyNumber -= 1;
                numAleat = random.Next(4,11);
                pfMiedo.GetComponent<MiedoIA>().SetSpeed(numAleat);

                Instantiate(pfMiedo,transform.position,Quaternion.identity);
            }
        }
    }
}
