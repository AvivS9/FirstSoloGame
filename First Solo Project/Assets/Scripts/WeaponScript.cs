using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject parent;

    private int numOfGuns;
    public GunData[] GunData;
    public GameObject[] GunModels;
    public int damage;
    public int AmmoInMagazine;
    public int NumOfMagazines;
    public string GunName;
    public int shotRate;
    private int gunIndex = 0;

    void Start()
    {
        numOfGuns = GunModels.Length;
        changeGun(0);
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)//scroll wheel up
        {
            Debug.Log("scrollup");
            gunIndex = (gunIndex + 1) % GunModels.Length;
            changeGun(gunIndex);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)//scroll wheel down
        {
            if (gunIndex == 0)
                gunIndex = GunModels.Length - 1;
            else
                gunIndex--;
            Debug.Log(gunIndex);

            changeGun(gunIndex);
        }
    }

    void changeGun(int index)
    {

        changeGun3DModel();

        damage = GunData[index].damage;
        AmmoInMagazine = GunData[index].AmmoPerMagazine;
        NumOfMagazines = GunData[index].MaxNumOfMagazines - 1; //one magazine is loaded
        GunName = GunData[index].GunName;
        shotRate = GunData[index].shotRate;

        gameObject.GetComponent<Shooting>().changeAmmoText();

    }

    void changeGun3DModel()
    {
        int i = 0;
        foreach (Transform weapon in transform)//every object that is a child of our object
        {
            if (i == gunIndex)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }

            i++;
        }

    

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
                AmmoInMagazine += GunData[gunIndex].AmmoPerMagazine;
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
    }

}
