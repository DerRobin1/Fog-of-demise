using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    public float theDistance;
    public GameObject BigLetter;
    public GameObject EButton;
    public GameObject Player;
    public GameObject Trigger;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Next;
    public GameObject Cam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if (Input.GetKeyDown(KeyCode.E) && actionDisplay.activeSelf)
        {
            Player.SetActive(false);
            Cam.SetActive(true);
            BigLetter.SetActive(true);
            EButton.SetActive(true);
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
        }

    }

    void OnMouseOver()
    {
        if (theDistance <= 1 && Player.activeSelf)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (BigLetter.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            Cam.SetActive(false);
            Player.SetActive(true);
            BigLetter.SetActive(false);
            EButton.SetActive(false);
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            Next.SetActive(true);
            Trigger.SetActive(false);
        }
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
