using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBite : MonoBehaviour
{
    [SerializeField]    private bool _bitting = false;
    [SerializeField]    private float biteRange = 0.8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Bite();
        }
    }

    void Bite()
    {
        GameObject target = FindClosestItem();
        if (target & !_bitting)
        {
            target.GetComponent<GrabbedObject>().Grabbed();
            _bitting = !_bitting;
            return;
        }
        if (target & _bitting)
        {
            target.GetComponent<GrabbedObject>().Grabbed();
            _bitting = !_bitting;
        }
    }

    public GameObject FindClosestItem()
    {
        GameObject[] items;
        float range = biteRange;
        GameObject closest = null;
        
        // list all objects with tag "Grabbable"
        items = GameObject.FindGameObjectsWithTag("Grabbable");
        
        // center on player
        Vector3 position = transform.position;

        foreach (GameObject item in items)
        {
            // calculate distance to object
            Vector3 diff = item.transform.position - position;
            float distance = diff.sqrMagnitude;

            // replace if closer than previous
            if (distance < range)
            {
                closest = item;
                range = distance;
            }
        }
        return closest;
    }
}
