using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditosController : MonoBehaviour
{

    public GameObject o1,o2,o3,o4,o5;
    List<GameObject> lista ;
    public float time = 5f;
    public GameObject canva;
    bool mostrando = false;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(loadCredits(time));
       
    }


    IEnumerator loadCredits( float transitionTime)
  {
       mostrando = true;
       
       o1.gameObject.SetActive(true);
       yield return new WaitForSeconds(transitionTime);
       o1.gameObject.SetActive(false);
       o2.gameObject.SetActive(true);
       yield return new WaitForSeconds(transitionTime);
       o2.gameObject.SetActive(false);
       o3.gameObject.SetActive(true);
       yield return new WaitForSeconds(transitionTime);
       o3.gameObject.SetActive(false);
       o4.gameObject.SetActive(true);
       yield return new WaitForSeconds(transitionTime);
       o4.gameObject.SetActive(false);
       o5.gameObject.SetActive(true);
       yield return new WaitForSeconds(transitionTime);
       o5.gameObject.SetActive(false);
       yield return new WaitForSeconds(transitionTime);
       GameObject.FindGameObjectWithTag("Finish").GetComponent<Level1Loader>().LoadLevel1();
       mostrando = false;
  }
}
