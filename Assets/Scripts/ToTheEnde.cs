using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToTheEnde : MonoBehaviour
{

    public GameObject Fade;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(ZurZweiten());
        }
    }

    IEnumerator ZurZweiten()
    {
        Fade.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Endscene");
    }
}
