using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlebrijeAttack : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            anim.SetBool("Ataque", true);
            Attack();
        }
        if (Input.GetKeyUp("u")) 
        {
            anim.SetBool("Ataque", false);
        }
    }

    void Attack()
    {
        GameObject target = FindClosestEnemy();
        
        if (target)
        {
            target.GetComponent<Enemy_ReceiveDamage>().Damage();
        }
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        float biteRange = 1.5f;
        GameObject closest = null;
        
        // list all objects with tag "Enemy"
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        
        // center on player
        Vector3 position = transform.position;

        foreach (GameObject go in gos)
        {
            // calculate distance to object
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;

            // replace if closer than previous
            if (curDistance < biteRange)
            {
                closest = go;
                biteRange = curDistance;
            }
        }
        return closest;
    }
}
