using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlesMenu : MonoBehaviour
{
    [SerializeField] Text controlesPerro;
    [SerializeField] Text controlesAlebrije;
    // Start is called before the first frame update
    void Start()
    {
        
        controlesPerro.enabled = false;
        controlesAlebrije.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            Debug.Log(controlesPerro.enabled);
            controlesPerro.enabled = true;
            controlesAlebrije.enabled = true;
        }
        
        if(Input.GetKeyUp(KeyCode.C)){
            controlesPerro.enabled = false;
            controlesAlebrije.enabled = false;
        }
    }
}
