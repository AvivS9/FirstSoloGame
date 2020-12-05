using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{

    GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        PauseMenu = GameObject.FindGameObjectWithTag("Pause Menu");

        if (PauseMenu != null)
        {
            PauseMenu.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
