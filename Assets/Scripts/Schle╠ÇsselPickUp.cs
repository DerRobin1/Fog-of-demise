using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchlüsselPickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Mission1;
    public GameObject Mission2;
    public GameObject MissionS;
    public GameObject Schlüssel;
    public GameObject Cylinder;
    public AudioSource SoundMission;
    public GameObject Trigger2Priest;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 4)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                SoundMission.Play();
                Mission2.SetActive(true);
                MissionS.SetActive(true);
                Mission1.SetActive(false);
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                Cylinder.SetActive(true);
                Trigger2Priest.SetActive(true);
                Schlüssel.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
