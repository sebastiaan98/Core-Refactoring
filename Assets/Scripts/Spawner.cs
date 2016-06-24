using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public GameObject[] Enemy;
    public GameObject enemy;
    float NextSpawnTime;
    public float SpawnRate;
    float x;
    float y;
    float z;
    float deg;

    float now = 0;
    float width;
    float height;

    void Start()
    {
        StartCoroutine(WaitASec(30));
        width = 10;
        height = 10;
    }

    int i;
    void Update()
    {
        now = Random.Range(0, 360);
        deg = now * Mathf.Rad2Deg + 90;
        x = Mathf.Cos(now) * width;
        y = Mathf.Sin(now) * height;
        z = 10;

        i = Random.Range(0, 14);
            enemy = Enemy[i];
        if (Time.time >= NextSpawnTime)
        {
            if (Time.timeScale == 1)
            {
                Instantiate(enemy, transform.position, transform.rotation);
                transform.position = new Vector3(x, y, z);
                transform.rotation = Quaternion.Euler(0, 0, deg);
                NextSpawnTime = Time.time + SpawnRate;
            }
        }
    }
    IEnumerator WaitASec(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SpawnRate -= 0.2f;
    }
}
