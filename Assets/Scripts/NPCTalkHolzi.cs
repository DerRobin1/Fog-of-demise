using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCTalkHolzi : MonoBehaviour
{
    public float theDistance;
    public GameObject Sprechblase1;
    public GameObject Sprechblasen;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject WasWirdGesagt;
    public GameObject Trigger;
    public GameObject TriggerMenschen;
    public GameObject Player;
    public GameObject DialogBack;
    public GameObject Cam;
    public GameObject ETaste;
    public GameObject Kiste;
    public AudioSource Sound;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
        if (Input.GetKeyDown(KeyCode.R) && actionDisplay.activeSelf)
        {
            Sound.Play();
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            Player.SetActive(false);
            Sprechblase1.SetActive(false);
            Cam.SetActive(true);
            WasWirdGesagt.SetActive(true);
            DialogBack.SetActive(true);
            ETaste.SetActive(true);

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
            Sprechblasen.SetActive(true);
            TriggerMenschen.SetActive(true);
            Kiste.SetActive(true);
            Trigger.SetActive(false);
        }
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
