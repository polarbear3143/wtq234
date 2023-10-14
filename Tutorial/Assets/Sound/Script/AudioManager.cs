using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    [SerializeField] AudioSource AudioSource;

    public void Search()
    {
        GameObject objectSelected = GameObject.Find("Drone");

        objectSelected.transform.GetChild(0).gameObject.SetActive(true);

        AudioSource.PlayClipAtPoint(audioClip[0], objectSelected.transform.position);
    }

    public void Singanl()
    {
        AudioSource.PlayOneShot(audioClip[1]);
    }
}
