﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DirectorHandler : MonoBehaviour
{
    PlayableDirector pd;
    bool activado;

    GameObject Carga2;
    // Start is called before the first frame update

    void Start()
    {
        pd = GetComponent<PlayableDirector>();
        activado = false;
        Carga2 = GameObject.FindGameObjectWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        if (activado == false && pd.time > 9.3f && pd.time < 14.0f) {
            this.transform.GetChild(0).gameObject.SetActive(true);
            activado = true;
        }
        if (activado == true && pd.time > 14.5f)
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
            activado = false;
        }
        if (pd.time > 16.0f)
        {
            Carga2.GetComponent<Level1Loader>().LoadLevel1();
        }
    }
}
