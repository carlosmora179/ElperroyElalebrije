using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMiedo : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRatio = 2f;
    public int enemyNumber = 10;
    private float timer =0f;

    [SerializeField] private Transform pfMiedo;
   
    void Update()
    {

        if(timer <= spawnRatio){
                 timer += Time.deltaTime;
             }
             else{
                 timer = 0f;
             
                if(enemyNumber > 0){
                    enemyNumber -= 1; 
                    Instantiate(pfMiedo,transform.position,Quaternion.identity);  
                }
             }

        
        
    }
    
}
