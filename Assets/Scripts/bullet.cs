using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    public GameObject particle;
    public int player;
    void Update () {
		transform.Translate (Vector3.up * 12 * Time.deltaTime);
	}
    void Start()
    {
        Destroy(gameObject, 5);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Enemy")
        {
            GameObject i = Instantiate(particle, transform.position, transform.rotation) as GameObject;
            Destroy(i, 1.0f);
            GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayDieSound();
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.FindGameObjectWithTag("punten").GetComponent<PuntenTeller>().AddPoints(10, player);
        }     
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
