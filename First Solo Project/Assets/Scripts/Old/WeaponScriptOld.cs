using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScriptOld : MonoBehaviour
{
    /*
    public GameObject parent;

    //private int numOfGuns;
    //public GunData[] GunData;
    public List<GunData> gunInventory;
    public int damage;
    public int AmmoInMagazine;
    public int NumOfMagazines;
    public string GunName;
    public int shotRate;
    private int gunIndex = 0;
    private GameObject current3dmodel;
    private AudioSource shotsound;


    void Start()
    {
        //numOfGuns = gunInventory.Count;
        shotsound = transform.GetComponent<AudioSource>();
        gunInventory = Inventory.instance.guns;
        if (gunInventory.Count != 0)
            current3dmodel = Instantiate(gunInventory[0].model3Dprefab, transform.position, transform.rotation, transform);

        changeGun(gunIndex);
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)//scroll wheel up
        {
            SaveCurrentAmmo(gunIndex);
            Debug.Log("scrollup");
            gunIndex = (gunIndex + 1) % gunInventory.Count;
            changeGun(gunIndex);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)//scroll wheel down
        {
            SaveCurrentAmmo(gunIndex);
            if (gunIndex == 0)
                gunIndex = gunInventory.Count - 1;
            else
                gunIndex--;
            Debug.Log(gunIndex);

            changeGun(gunIndex);
        }
    }

    void changeGun(int index)
    {

        changeGun3DModel();

        damage = gunInventory[index].damage;
        AmmoInMagazine = gunInventory[index].AmmoPerMagazine;
        NumOfMagazines = gunInventory[index].currentNumOfMagazines - 1; //one magazine is loaded
        GunName = gunInventory[index].GunName;
        shotRate = gunInventory[index].shotRate;

        shotsound.clip = gunInventory[index].shotsound;
        gameObject.GetComponent<Shooting>().changeAmmoText();

    }
    
    void changeGun3DModel()
    {
        Destroy(current3dmodel);
        current3dmodel = Instantiate(gunInventory[gunIndex].model3Dprefab, transform.position, transform.rotation, transform);

    }

    void SaveCurrentAmmo(int index)
    {
      
        gunInventory[index].damage = damage;
        gunInventory[index].AmmoPerMagazine = AmmoInMagazine;
        gunInventory[index].currentNumOfMagazines = NumOfMagazines + 1; //one magazine is loaded
    }



    public bool enoughAmmo()//we will check this to see if we can shoot
    {
        if (AmmoInMagazine > 0 || NumOfMagazines > 0)
            return true;
        return false;
    }

    public void decreaseAmmo(int decreaseAmount)
    {

        if (AmmoInMagazine - decreaseAmount <= 0)
        {
            if (NumOfMagazines > 0)
            {
                AmmoInMagazine += gunInventory[gunIndex].AmmoPerMagazine;
                AmmoInMagazine -= decreaseAmount;
                NumOfMagazines--;
            }
            else
                AmmoInMagazine = 0;
        }
        else
        {
            AmmoInMagazine -= decreaseAmount;
        }  

    }

    public int getNumMagazines()
    {
        return NumOfMagazines;
    }

    public int getAmmoInMagazine()
    {
        return AmmoInMagazine;
    }*/

}
