using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform pickupLocation;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        //disable freezerotation so that it stops moving when picked up.
        GetComponent<Rigidbody>().freezeRotation = true;
        this.transform.position = pickupLocation.position;
        //this.transform.parent = GameObject.Find("ObjectPosition").transform;
        //make the picked up object follow the position of the FPS when he moves
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    private void OnMouseUp()
    {
        //release object and enable back the gravity.
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        //enable back the freezerotation so that it moves like an actual object again.
        GetComponent<Rigidbody>().freezeRotation = false;
    }



}
