using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : Interactable
{

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
    }
}
