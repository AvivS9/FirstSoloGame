using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Interactable
{
    public int id = 0;

    public override void interact()
    {
        base.interact();

        PauseMenu.instance.addLetter(id);

        Destroy(gameObject);
    }
}
