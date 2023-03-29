using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneEnde : MonoBehaviour
{
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject Fade;
    public GameObject Black;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(EndeCut());
    }

    IEnumerator EndeCut()
    {
        C1.SetActive(true);
        yield return new WaitForSeconds(3);
        C1.SetActive(false);
        C2.SetActive(true);
        yield return new WaitForSeconds(4);
        C2.SetActive(false);
        C3.SetActive(true);
        yield return new WaitForSeconds(4);
        C3.SetActive(false);
        C4.SetActive(true);
        yield return new WaitForSeconds(3);
        Fade.SetActive(true);
        yield return new WaitForSeconds(2);
        Black.SetActive(true);
        T1.SetActive(true);
        yield return new WaitForSeconds(5);
        T1.SetActive(false);
        T2.SetActive(true);
        yield return new WaitForSeconds(5);
        T2.SetActive(false);
        T3.SetActive(true);
        yield return new WaitForSeconds(5);
        T3.SetActive(false);
        T4.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("HauptMenu");
    }
}
