using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiedoIA : MonoBehaviour
{
    public float speed = 4f;
    public float RadioVision = 2.5f;
    public float RadioAtaque = 1f;

    GameObject player;
    private Animator anim;
    
    Rigidbody2D rb2d;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = player.transform.position;
         
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            player.transform.position - transform.position,
            RadioVision,
            1 << LayerMask.NameToLayer("Default")


        );
        
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

        if(hit.collider != null){
            if(hit.collider.tag == "Player"){
                
                
                
                

            }
            
        }


        
        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;
    
        if( distance < RadioAtaque){
            
            Debug.Log("lo ataco");
        }
        
            
        rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);
            
        Debug.DrawLine(transform.position, target, Color.green);

        if (dir != Vector3.zero) 
        {
            anim.SetFloat("movX", dir.x);
            anim.SetFloat("movY", dir.y);
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }

    }

    public void SetSpeed(float newSpeed){
        speed = newSpeed;


    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,RadioVision);
        Gizmos.DrawWireSphere(transform.position,RadioAtaque);
    }

     
}
