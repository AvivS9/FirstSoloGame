using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public int id;

    

    public void BtnPress()
    {
        PauseMenu.instance.showLetter(id);
    }
}
