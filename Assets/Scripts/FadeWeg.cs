using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeWeg : MonoBehaviour
{
    public GameObject Fade;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadenWeg());
    }

    IEnumerator FadenWeg()
    {
        yield return new WaitForSeconds(2);
        Fade.SetActive(false);
    }
}
