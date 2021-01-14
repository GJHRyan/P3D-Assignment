using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget; //target portal position
    public GameObject playerObject; //current player position

    void OnTriggerEnter(Collider other)
    {
        //make the player appear at the other portal's position
        playerObject.transform.position = teleportTarget.transform.position;    
    }
}
