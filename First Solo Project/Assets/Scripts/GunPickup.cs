using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : Interactable
{

    public GameObject player;
    public GunData gun;
    public override void interact()
    {
        //base.interact();//calls the regular interact method



        Pickup();
    }

    void Pickup()
    {
        Debug.Log("picking up " + gun.GunName);
        bool wasadded = Inventory.instance.AddGun(gun);
        if (wasadded)
            Destroy(gameObject);
        //createguninhand(gun);
    }

    /*
    void createguninhand(GunData gun)
    {
        GameObject gunmodel = Instantiate(gun.model3Dprefab, player.transform.position, player.transform.rotation, player.transform);
        gunmodel.transform.Rotate(0.0f, 180.0f, -40.0f, Space.World);
    }*/
}
