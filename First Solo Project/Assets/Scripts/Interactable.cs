using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f; //how close the player needs to be to interact

    private void OnDrawGizmosSelected()//this draws a radius sphere in the scene view
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public virtual void interact()
    {
        //change this method in each class that inherits it
        Debug.Log("interacting");
    }
}
