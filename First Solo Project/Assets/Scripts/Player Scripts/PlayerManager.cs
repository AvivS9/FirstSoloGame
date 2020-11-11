using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject player;
    public GameObject fpscontroller;
    // Start is called before the first frame update
    void Awake ()
    {
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //make enemy chase after you
            EnemyManager.instance.enemy.GetComponent<EnemyAICharacterControl>().SetTarget(fpscontroller.transform.position);
        }
            
    }
}
