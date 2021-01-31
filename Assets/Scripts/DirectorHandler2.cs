﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DirectorHandler2 : MonoBehaviour
{
    PlayableDirector pd;
    GameObject Carga2;
    // Start is called before the first frame update
    void Start()
    {
        pd = GetComponent<PlayableDirector>();
        Carga2 = GameObject.FindGameObjectWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        if (pd.time > 10.5f)
        {
            //Aqui va la transicion.
            Carga2.GetComponent<Level1Loader>().LoadLevel1();
        }
    }
}
