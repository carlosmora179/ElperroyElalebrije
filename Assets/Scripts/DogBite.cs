﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBite : MonoBehaviour
{
    [SerializeField]
    private bool _bitting = false;

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
        GameObject[] gos;
        // list all objects with tag "Grabbable"
        gos = GameObject.FindGameObjectsWithTag("Grabbable");
        GameObject closest = null;
        float biteRange = 1f;
        // center on player
        Vector3 position = transform.position;
        // check each object from furthest to closest
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < biteRange)
            {
                closest = go;
                biteRange = curDistance;
            }
        }
        return closest;
    }
}