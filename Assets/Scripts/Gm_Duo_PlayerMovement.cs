using UnityEngine;
using System.Collections;

public class Gm_Duo_PlayerMovement : MonoBehaviour {
    public int player;

    public GameObject bullet;

    private float now = 0;
    private float deg;
    private float width;
    private float height;
    private float x;
    private float y;
    private float z;

    public float speed = 0.1f;

    void Start()
    {
        width = .95f;
        height = .95f;
    }
    void Update()
    {
        Shoot(0.5f);
        Move();

        deg = now * Mathf.Rad2Deg - 90;

        x = Mathf.Cos(now) * width;
        y = Mathf.Sin(now) * height;
        z = 10;

        transform.position = new Vector3(x, y, z);
        transform.rotation = Quaternion.Euler(0, 0, deg);
    }

    float nft;
    void Shoot(float sr)
    {

        if (player == 1)
        {
            if (Input.GetKey(KeyCode.I) && Time.time >= nft)
            {
                GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayShootSound();
                //play audio
                GameObject i = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
                nft = Time.time + sr;
            }
        }
        else if (player == 2)
        {
            if (Input.GetKey(KeyCode.W) && Time.time >= nft)
            {
                GameObject.FindGameObjectWithTag("sound").GetComponent<SoundManager>().PlayShootSound();
                //play audio
                GameObject i = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
                nft = Time.time + sr;
            }
        }
    }
    void Move()
    {
        if (player == 1)
        {
            if (Input.GetKey(KeyCode.J))
            {
                now += speed;
            }
            if (Input.GetKey(KeyCode.L))
            {
                now -= speed;
            }
        }
        else if (player == 2)
        {
            if (Input.GetKey(KeyCode.A))
            {
                now += speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                now -= speed;
            }
        }
    }

    IEnumerator Stunned()
    {
        yield return new WaitForSeconds(1f);
    }
}
