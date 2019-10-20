using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator soldierAnimator;
    public Animator doorAnimator;


    void OnTriggerEnter2D()
    {
        soldierAnimator.SetBool("isWaving", true);
        doorAnimator.SetBool("isOpen", true);
    }

    void OnTriggerExit2D()
    {
        soldierAnimator.SetBool("isWaving", false);
        doorAnimator.SetBool("isOpen", false);       
    }
}
