using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
 public GameObject bot;
public GameObject player;
// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnbot", 2.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {}
void Spawnbot()
{
 Vector3 playerPos = player.transform.position;
 Vector3 playerDirection = player.transform.right;
 Quaternion playerRotation = player.transform.rotation;
 float spawnDistance = 10;
 
 Vector3 spawnPos = playerPos + playerDirection*spawnDistance;
 
 Instantiate(bot, spawnPos, playerRotation );
    }
}
