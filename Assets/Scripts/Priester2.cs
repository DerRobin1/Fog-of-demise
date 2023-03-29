using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priester2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject DialogBack;
    public GameObject Dialog25;
    public GameObject Cam;
    public GameObject ETaste;
    public GameObject Trigger;
    public GameObject TriggerEnde;
    public GameObject PriesterCylinder;
    public GameObject Mission;
    public GameObject Mission1;
    public GameObject MissionS;
    public AudioSource Sound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Sound.Play();
            PriesterCylinder.SetActive(false);
            Player.SetActive(false);
            Cam.SetActive(true);
            Dialog25.SetActive(true);
            DialogBack.SetActive(true);
            ETaste.SetActive(true);

        }
    }

    void Update()
    {
        if (Dialog25.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            Dialog25.SetActive(false);
            DialogBack.SetActive(false);
            ETaste.SetActive(false);
            TriggerEnde.SetActive(true);
            Mission.SetActive(false);
            MissionS.SetActive(false);
            Mission1.SetActive(true);
            Trigger.SetActive(false);
        }
    }
}
