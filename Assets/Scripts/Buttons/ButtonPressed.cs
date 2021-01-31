using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private GameObject canvas;
    private bool isEnter;
    [SerializeField]
    float startTime = 0f;
    [SerializeField]
    float holdTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        isEnter = false;
    }

    void Update()
    {
        CheckKeyPress();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canvas.SetActive(true);
            isEnter = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canvas.SetActive(false);
            isEnter = false;
        }
    }

    void CheckKeyPress()
    {
        if (isEnter)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.RightShift))
            {
                startTime = Time.time;
            }
            if (Input.GetKey(KeyCode.E))
            {
                if (startTime + holdTime <= Time.time)
                {
                    print("barrier");
                    obstacle.GetComponent<Collider2D>().enabled = false;
                }
            }
        }
        if( Input.GetKeyDown(KeyCode.RightShift)){
             if (startTime + holdTime <= Time.time)
                {
                    print("barrier");
                    obstacle.GetComponent<Collider2D>().enabled = false;
                }
        }
    }
}
