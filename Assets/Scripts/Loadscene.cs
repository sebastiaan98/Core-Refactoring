using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class Loadscene : MonoBehaviour {
	public void SceneSelect(int scene)
	{
        GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayClickSound();
		SceneManager.LoadScene (scene);
        Time.timeScale = 1;

	}
	public void QuitGame(){
		Application.Quit();
		
	}
}
