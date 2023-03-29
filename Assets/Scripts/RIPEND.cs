using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RIPEND : MonoBehaviour
{
    public float theDistance;
    public GameObject Player;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Fade;
    public GameObject Blood;
    public AudioSource Schwert;
    public AudioSource EndeTot;

    void OnMouseOver()
    {
        if (theDistance <= 1 && Player.activeSelf)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

    }

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if (Input.GetKeyDown(KeyCode.E) && actionDisplay.activeSelf)
        {

            StartCoroutine(Ende());
        }

    }

    IEnumerator Ende()
    {
        Schwert.Play();
        Blood.SetActive(true);
        yield return new WaitForSeconds(1);
        EndeTot.Play();
        Fade.SetActive(true);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("EndCut");
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
