using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
    public int player,other;
    public GameObject particle;
    public Sprite i, j, k;
	public float health = 300;

    void Update()
    {
        if(health == -100)
        {
            GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().GameOverSound();
            GameObject i = Instantiate(particle, transform.position, transform.rotation) as GameObject;
            Destroy(i, 1.0f);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<Gm_Pvp_GameHandler>().StartCoroutine(GameObject.FindGameObjectWithTag("GameController").GetComponent<Gm_Pvp_GameHandler>().GameOver(other));
        }
        if(health <= 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = k;
            
        }
        if(health == 200)
        {
            this.GetComponent<SpriteRenderer>().sprite = i;
        }
        if(health == 100)
        {
            this.GetComponent<SpriteRenderer>().sprite = j;
        }
    }
	void levelReset()
	{
		SceneManager.LoadScene ("main menu");
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            Destroy(other.gameObject);
            health -= 100;
            GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().TookDmgSound();
        }
    }
}	

