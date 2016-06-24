using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {
    public GameObject pausepannel;

    public bool isPaused;

	
	void Start () {
        isPaused = false;
	}
	
	
	void Update () {
	if (isPaused)
        {
            PauseGame(true);
        }
        else
        {
            PauseGame(false);
        }
    if(Input.GetKeyDown(KeyCode.P))
        {
            SwitchPause();

        }

	}
   


    void PauseGame (bool state)
    {
        if (state)
        {
            
            Time.timeScale = 0.0f; //pauze
        }
        else
        {
            Time.timeScale = 1.0f; //play
           }
        pausepannel.SetActive(state);
        }
    public void SwitchPause()
    {
        if (isPaused) {
            isPaused = false; //changes the value
        }
        else{
            isPaused = true;

        }

    }
}
