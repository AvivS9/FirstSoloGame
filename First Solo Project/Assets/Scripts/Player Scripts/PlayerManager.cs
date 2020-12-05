using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public bool playing = true;
    // Start is called before the first frame update
    void Awake ()
    {
        instance = this;

        
    }

    
}
