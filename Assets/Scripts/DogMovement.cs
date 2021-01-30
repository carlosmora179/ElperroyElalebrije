using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{
    // player movement speed
    [SerializeField]    
    private float _speed = 3.5f;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _MovePlayer();
    }

    void _MovePlayer()
    {
        // get user input (horizontal)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        // get user input (vertical)
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        // move player
        transform.Translate(direction * _speed * Time.deltaTime);

        anim.SetFloat("MovX", direction.x);
        anim.SetFloat("MovY", direction.y);
    }
}