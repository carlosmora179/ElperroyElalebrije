using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlebrijeMovement : MonoBehaviour
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
        _MovePlayer();
    }

    void _MovePlayer()
    {
        // get user input (horizontal)
        float horizontalInput = Input.GetAxisRaw("Horizontal1");
        // get user input (vertical)
        float verticalInput = Input.GetAxisRaw("Vertical1");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        // move player
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}