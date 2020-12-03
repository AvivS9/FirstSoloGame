using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallBack;


    public static Inventory instance;


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
   
}
