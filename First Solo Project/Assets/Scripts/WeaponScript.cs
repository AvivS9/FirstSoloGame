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
    public int AmmoPerMagazine;
    public int MaxNumOfMagazines;
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
        AmmoPerMagazine = GunData[index].AmmoPerMagazine;
        MaxNumOfMagazines = GunData[index].MaxNumOfMagazines;
        GunName = GunData[index].GunName;
        shotRate = GunData[index].shotRate;

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


        /*
        for (int i=0; i < numOfGuns; i++)
        {
            if (i == gunIndex)
            {
                GunModels[i].SetActive(true);
            }
            else
            {
                GunModels[i].SetActive(false);
            }
        }*/

    }
}
