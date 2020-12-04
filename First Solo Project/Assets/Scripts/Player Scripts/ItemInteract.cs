using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{

    private Camera fpscam;
    public float range = 100f;


    // Start is called before the first frame update
    void Start()
    {
        fpscam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.instance.playing == false)
            return;

        if (Input.GetKeyDown("e"))
        {
            interact();
        }
    }

    void interact()
    {
        
        RaycastHit hit;

        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))//hit raycast from camera in range
        {     

           Interactable interactableItem = hit.collider.GetComponent<Interactable>();
           if (interactableItem != null) //we hit an interactable item
           {
                if (Vector3.Distance(transform.position, hit.transform.position) <= interactableItem.radius)
                {
                    interactableItem.interact();
                }

           }

        }
            
    }
}
