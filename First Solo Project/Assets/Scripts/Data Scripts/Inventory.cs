using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallBack;


    public static Inventory instance;
    public List<GunData> guns = new List<GunData>();

    public int maxInventorySpace = 20;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one inventory instance found");
            return;
        }
        instance = this;
    }
    public bool AddGun (GunData gun)
    {
        if (guns.Count > maxInventorySpace)
        {
            Debug.Log("inventory full");
            return false;
        }
        guns.Add(gun);

        if(OnItemChangedCallBack != null)//check that there is a method subscribed to it
            OnItemChangedCallBack.Invoke();

        return true;
    }

    public void RemoveGun (GunData gun)
    {
        guns.Remove(gun);
        if (OnItemChangedCallBack != null)//check that there is a method subscribed to it
            OnItemChangedCallBack.Invoke();
    }

   
}
