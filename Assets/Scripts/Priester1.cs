using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priester1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject DialogBack;
    public GameObject Dialog22;
    public GameObject Cam;
    public GameObject ETaste;
    public GameObject Trigger;
    public GameObject TriggerLeute;
    public GameObject Sprechblasen;
    public GameObject PriesterCylinder;
    public GameObject Mission;
    public GameObject Mission1;
    public AudioSource Sound;
    public AudioSource SoundMission;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Sound.Play();
            PriesterCylinder.SetActive(false);
            Player.SetActive(false);
            Cam.SetActive(true);
            Dialog22.SetActive(true);
            DialogBack.SetActive(true);
            ETaste.SetActive(true);

        }
    }

    void Update()
    {
        if (Dialog22.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            SoundMission.Play();
            Player.SetActive(true);
            Cam.SetActive(false);
            Dialog22.SetActive(false);
            DialogBack.SetActive(false);
            ETaste.SetActive(false);
            Sprechblasen.SetActive(true);
            TriggerLeute.SetActive(true);
            Mission.SetActive(false);
            Mission1.SetActive(true);
            Trigger.SetActive(false);
        }
    }
}
