using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public Transform spawnpoint; //the point at which the player will be respawned
    public float minHeightforDeath; //the minimum height to go below to get respawned
    public GameObject Player; //the car of the player
    
    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y < minHeightforDeath)
        {
            Player.transform.position = spawnpoint.position;
            Player.transform.rotation = spawnpoint.rotation;
        }
        
    }
}
