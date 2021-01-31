using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FearMeditor : MonoBehaviour
{
    [SerializeField]
    FearBar barra;
    // Start is called before the first frame update
    void Start()
    {
        barra.SetMaxFear(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (barra.slider.value == 10)
        {
            SceneManager.LoadScene("Level1");
        }
    }

    public void increase()
    {
        barra.SetFear(1);
    }
}
