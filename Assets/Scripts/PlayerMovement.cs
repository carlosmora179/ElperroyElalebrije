using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // player movement speed
    [SerializeField]    
    private float _speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get user input (horizontal)
        float horizontalInput = Input.GetAxis("Horizontal");
        // get user input (vertical)
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        // move player
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}