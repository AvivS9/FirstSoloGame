using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollide : MonoBehaviour
{

    public GameObject destroyedBottle;


    /*
    private void OnMouseDown()
    {
        destroyBottle();
    }
    */

    public void destroyObject()
    {
        Instantiate(destroyedBottle, transform.position, transform.rotation);
        //Instantiate(destroyedBottle, transform);

        Destroy(gameObject);
    }
   
}
