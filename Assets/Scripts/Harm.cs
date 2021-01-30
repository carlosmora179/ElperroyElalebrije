using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harm : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            collision.GetComponent<MiedoHealth>().Damage();
        }
    }
}
