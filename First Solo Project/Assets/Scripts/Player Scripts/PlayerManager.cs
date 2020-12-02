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
        if (Input.GetKeyDown("g"))
        {
            //make enemy chase after you
            Debug.Log("lalal " + fpscontroller.transform.position);
            //EnemyManager.instance.enemy.GetComponent<EnemyAI>().SetTarget(fpscontroller.transform.position);
            
        }

        if (Input.GetKeyDown("s"))
        {
            //make enemy stop chasing after you
            //EnemyManager.instance.enemy.GetComponent<EnemyAI>().stopMoving();

        }

    }
}
