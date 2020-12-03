using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Interactable
{
    public int id = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    public override void interact()
    {
        base.interact();

        PauseMenu.instance.addLetter(id);
    }
}
