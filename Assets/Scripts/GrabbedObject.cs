using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbedObject : MonoBehaviour
{
    [SerializeField]
    public bool _grabbed = false;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectMovement();
    }

    public void Grabbed()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        _grabbed = !_grabbed;
    }

    void objectMovement()
    {
        if (_grabbed)
        {
            transform.position = playerTransform.position;
        }
    }
}