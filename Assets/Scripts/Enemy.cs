using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float Speed;
  
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        
    }
}

