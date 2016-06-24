using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class instructies : MonoBehaviour {
    public int scene;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayClickSound();
            SceneManager.LoadScene(scene);
            Time.timeScale = 1;
        }

    }
}
