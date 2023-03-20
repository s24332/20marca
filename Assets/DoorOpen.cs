using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("DoorOpen", true);      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("DoorOpen", false);
    }
}
