using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    //public GameObject player;
    //public GameObject fpscontroller;

    public bool playing = true;
    // Start is called before the first frame update
    void Awake ()
    {
        instance = this;

        //player = this.gameObject;
    }

    
}
