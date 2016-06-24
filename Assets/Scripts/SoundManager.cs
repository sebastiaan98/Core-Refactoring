using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

    public AudioClip[] clips;
    public AudioClip click;
    public AudioSource audioSource;
    public GameObject instance;
    public AudioClip die;
    public AudioClip gm;
    public AudioClip td;

    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayShootSound()
    {
        int i = 0;
        audioSource.PlayOneShot(clips[i], 1f);
        i = Random.Range(0, 3);
    }
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(click, 1f);
    }
    public void PlayDieSound()
    {
        audioSource.PlayOneShot(die, 1f);
    }
    public void TookDmgSound()
    {
        audioSource.PlayOneShot(td, 1f);
    }
    public void GameOverSound()
    {
        audioSource.PlayOneShot(gm, 1f);
    }

}   

