using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    Animator anim;

    void Start()
    {
        //get animator contoller
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //activate the door animation on trigger of the sphere collider
        anim.SetTrigger("OpenDoor"); 

    }
    private void OnTriggerExit(Collider other)
    {
        //re-enable the animator when the player has left the collider's radius
        anim.enabled = true;
    }
    private void pauseDoorAnimation()
    {
        //disable the door animation while the player is in the collider's radius
        anim.enabled = false;
    }
}
