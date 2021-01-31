using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlebrijeMovement : MonoBehaviour
{
    // player movement speed
    [SerializeField]    
    private float _speed = 3.5f;

    [SerializeField]
    private float radius = 6f;

    Vector3 totemPosition;
    private Animator anim;


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
        float horizontalInput = Input.GetAxisRaw("Horizontal1");
        // get user input (vertical)
        float verticalInput = Input.GetAxisRaw("Vertical1");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        // move player
        transform.Translate(direction * _speed * Time.deltaTime);
        
        // get totem position
        totemPosition = GameObject.Find("Totem").transform.position;

        // calculate distance from totem
        float totemDistance = Vector3.Distance(transform.position, totemPosition);

        if (totemDistance > radius)
        {
            Vector3 leashLength = transform.position - totemPosition;
            leashLength *= radius / totemDistance;
            transform.position = totemPosition + leashLength;
        }

        anim.SetFloat("MovX", direction.x);
        anim.SetFloat("MovY", direction.y);
    }
}