using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    public float theDistance;
    public GameObject Sprechblase;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject WasWirdGesagt;
    public GameObject Trigger;
    public GameObject Player;
    public GameObject DialogBack;
    public GameObject Cam;
    public GameObject ETaste;
    public AudioSource Sound;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
        if (Input.GetKeyDown(KeyCode.R) && actionDisplay.activeSelf)
        {
            Sound.Play();
            Player.SetActive(false);
            Cam.SetActive(true);
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            WasWirdGesagt.SetActive(true);
            DialogBack.SetActive(true);
            ETaste.SetActive(true);
            Sprechblase.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        if (theDistance <= 1 && Player.activeSelf)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
        }

        if (WasWirdGesagt.activeSelf && ETaste.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            Player.SetActive(true);
            Cam.SetActive(false);
            WasWirdGesagt.SetActive(false);
            DialogBack.SetActive(false);
            ETaste.SetActive(false);
            Trigger.SetActive(false);
        }
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
