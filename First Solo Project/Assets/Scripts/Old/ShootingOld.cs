using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class ShootingOld : MonoBehaviour
{
    /*
    public GunData gundata;

    public Camera fpscam;
    public float range = 100f;
    public float damage = 10f;
    public float impactForce = 10f;
    private AudioSource shotsound;

    public ParticleSystem muzzleflash;
    public GameObject impactEffect;

    public Text AmmoText;

    private void Start()
    {
        shotsound = transform.GetComponent<AudioSource>();
        changeAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (gameObject.GetComponent<WeaponScript>().enoughAmmo())
        {
            if (muzzleflash!= null)
                muzzleflash.Play();
            shotsound.Play();
            

            RaycastHit hit;

            if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))//hit raycast from camera in range
            {
                Debug.Log(hit.transform.tag);
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * impactForce);
                    if (hit.transform.tag == "Object")
                        hit.transform.gameObject.SendMessageUpwards("destroyObject");
                }
                //GameObject impactreference = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(-hit.normal));//make it hit in the direction of the normal to the object
                //Destroy(impactreference, 2f);//desteroy it after 2 seconds
                
                

                Interactable interactableItem = hit.collider.GetComponent<Interactable>();
                if (interactableItem != null) //we hit an interactable item
                {

                    if (Vector3.Distance(transform.position, hit.transform.position) <= interactableItem.radius)
                    {
                        interactableItem.interact();
                    }
                    
                }
         
            }
            gameObject.GetComponent<WeaponScript>().decreaseAmmo(1);
            changeAmmoText();
        }
        else
        {
            Debug.Log("no more ammo");
        }
        
    }

    public void changeAmmoText()
    {
        string ammo = gameObject.GetComponent<WeaponScript>().getAmmoInMagazine().ToString();
        string magazines = gameObject.GetComponent<WeaponScript>().getNumMagazines().ToString();


        AmmoText.text = "Ammo: " + ammo + "\n" + "Magazines: " + magazines;


    }*/
}
