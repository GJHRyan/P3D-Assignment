using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject newCube;

    private void OnTriggerEnter(Collider other)
    {
        //create a new cube a fixed location everytime the player triggers this collider.
        Instantiate(newCube, spawnPoint.position, spawnPoint.rotation);
    }
}
