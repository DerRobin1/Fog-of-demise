using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject Kind;
    public GameObject Triggerk;
    public AudioSource Sound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Jump1());

        }
    }

    IEnumerator Jump1()
    {
        Kind.SetActive(false);
        Sound.Play();
        yield return new WaitForSeconds(2);
        Triggerk.SetActive(false);
    }
}
