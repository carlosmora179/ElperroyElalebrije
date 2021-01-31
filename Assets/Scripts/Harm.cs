using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harm : MonoBehaviour
{
    public float Ratio = 7f;
    public GameObject player;
    Vector3  target;
    private float timer =0f;
   public float radius = 6f;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() {

        if(timer <= Ratio)
        {
            
            timer += Time.deltaTime;
        }
        
        else
        {
                timer = 0f;

            
            Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
                Debug.DrawRay(transform.position, forward, Color.red);

            
            target = player.transform.position;
                
            
            float distance = Vector3.Distance(target, transform.position);
            if(distance < radius){
                
                player.GetComponent<FearMeditor>().decrease();

            }
            if(distance > radius){
                
                player.GetComponent<FearMeditor>().increase();
            }
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            collision.GetComponent<MiedoHealth>().Damage();
        }

           
    }
    void OnDrawGizmosSelected(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,radius);
        
    }
}
