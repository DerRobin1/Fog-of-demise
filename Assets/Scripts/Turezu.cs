using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turezu : MonoBehaviour
{
    public GameObject Tur;
    public GameObject Triggerk;
    public AudioSource Sound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Jump2());

        }
    }

    IEnumerator Jump2()
    {
        Tur.GetComponent<Animator>().Play("Buhuuu");
        Sound.Play();
        yield return new WaitForSeconds(2);
        Triggerk.SetActive(false);
    }
}
