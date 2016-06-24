using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class menu : MonoBehaviour
{
    public GameObject soundmanager;
    void Start()
    {
        Time.timeScale = 1;
        Instantiate(soundmanager);
    }
}
