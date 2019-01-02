using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByTime : MonoBehaviour
{
    public float timeToSpawn;
    public float currentSeconds;
    
    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update ()
    {
        currentSeconds += Time.deltaTime;
    }
}