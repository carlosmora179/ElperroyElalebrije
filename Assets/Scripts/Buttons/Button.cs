using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private GameObject canvas;
    private bool isEnter;

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
            if (Input.GetKeyDown(KeyCode.E))
            {
                obstacle.GetComponent<Collider2D>().enabled = false;
            }
        }
    }
}
