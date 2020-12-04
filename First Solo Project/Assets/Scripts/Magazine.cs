using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : Interactable
{

    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");

        if (player.GetComponentInChildren<WeaponScript>() == null)
            Debug.Log("problem");
        
    }
    public override void interact()
    {
        base.interact();

        player.GetComponentInChildren<WeaponScript>().addMagazine();

        Destroy(gameObject);
        //player.GetComponent<WeaponScript>().addMagazine(); 
    }

    
}
