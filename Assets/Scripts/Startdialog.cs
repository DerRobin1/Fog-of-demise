using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startdialog : MonoBehaviour
{
    public GameObject Player;
    public GameObject DialogBack;
    public GameObject Dialog1;
    public GameObject Cam;
    public GameObject ETaste;
    public GameObject Trigger;
    public GameObject Priester;
    public GameObject Mission;
    public GameObject Mission1;
    public AudioSource Sound;
    public AudioSource SoundMission;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Sound.Play();
            Player.SetActive(false);
            Cam.SetActive(true);
            Dialog1.SetActive(true);
            DialogBack.SetActive(true);
            ETaste.SetActive(true);

        }
    }

    void Update()
    {
        if (Dialog1.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            SoundMission.Play();
            Player.SetActive(true);
            Cam.SetActive(false);
            Dialog1.SetActive(false);
            DialogBack.SetActive(false);
            ETaste.SetActive(false);
            Priester.SetActive(true);
            Mission.SetActive(true);
            Mission1.SetActive(true);
            Trigger.SetActive(false);
        }
    }
}
