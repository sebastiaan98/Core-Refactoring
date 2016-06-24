using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Gm_Pvp_GameHandler : MonoBehaviour {
    public GameObject dead;
    PuntenTeller pt;
    AudioSource au;
    public GameObject bigCircle;
    float now = 0;
    float width;
    float height;
    bool gameover = false;

    public void playAudio(AudioClip clip)
    {
        
        au.PlayOneShot(clip, 1f);
    }

    void Start()
    {
        pt = GameObject.FindGameObjectWithTag("punten").GetComponent<PuntenTeller>();
        au = GetComponent<AudioSource>();
        width = -3f;
        height = -3f;
    }

    void Update()
    {
        if (gameover)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);

            }
        }
        if (Time.timeScale != 0)
        {
            now += 0.1f;
            bigCircle.transform.rotation = Quaternion.Euler(0, 0, now);
        }
    }
    public IEnumerator GameOver(int playerwhowon)
    {
        gameover = true;
        Time.timeScale = 0;
        yield return new WaitForSeconds(3);
        dead.SetActive(true);
        punten i = dead.GetComponent<punten>();

        i.p1.text = "Player 1 got " + pt.puntenp1.ToString() + " points.";
        i.p2.text = "Player 2 got " + pt.puntenp2.ToString() + " points.";
        i.won.text = "Player " + playerwhowon.ToString() + " won";
    }
}
