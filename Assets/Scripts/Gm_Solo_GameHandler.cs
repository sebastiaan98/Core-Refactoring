using UnityEngine;
using System.Collections;

public class Gm_Solo_GameHandler : MonoBehaviour {
    AudioSource au;

    public void playAudio(AudioClip clip)
    {
        au.PlayOneShot(clip, 1f);
    }

    void Start()
    {
        au = GetComponent<AudioSource>();
    }

}
