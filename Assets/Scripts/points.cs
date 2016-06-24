using UnityEngine;
using System.Collections;

public class points : MonoBehaviour {
    public int playerwon;
    int player1p;
    int player2p;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}

    void OnLevelWasLoaded(int level)
    {
        if (level == 12)
        {
            Debug.Log("lmao");

        }
    }

    void Update () {
        player1p = GameObject.FindGameObjectWithTag("punten").GetComponent<PuntenTeller>().puntenp1;
        player2p = GameObject.FindGameObjectWithTag("punten").GetComponent<PuntenTeller>().puntenp2;
    }
}
