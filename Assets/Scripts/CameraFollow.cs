using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Dog").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // lateupdate to prevent issues
    void LateUpdate()
    {
        // save target position to temp variable
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;
        // update camera position
        transform.position = temp;
    }
}
