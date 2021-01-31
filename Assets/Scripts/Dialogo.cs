﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [SerializeField]
    Canvas canvasE;
    bool entro;
    // Start is called before the first frame update
    void Start()
    {
        entro = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        entro = true;
        canvasE.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        entro = false;
        canvasE.gameObject.SetActive(false);
    }
}
