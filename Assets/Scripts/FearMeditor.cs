using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FearMeditor : MonoBehaviour
{
    [SerializeField]
    FearBar barra;
    GameObject levelcontrol;
    // Start is called before the first frame update
    void Start()
    {
        barra.SetMaxFear(10);
        levelcontrol = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (barra.slider.value == 10)
        {
            levelcontrol.GetComponent<LevelLoader>().GameOver();
            //SceneManager.LoadScene("Level1");
        }
    }

    public void increase()
    {
        barra.SetFear(1);
    }
}
