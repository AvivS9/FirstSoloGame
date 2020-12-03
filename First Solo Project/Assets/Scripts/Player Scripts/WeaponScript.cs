using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    
    public GameObject parent;

    //private int numOfGuns;
    //public GunData[] GunData;
    //public List<GunData> gunInventory;

    public GunData gundata;
    private int damage;
    private int AmmoInMagazine;
    private int NumOfMagazines;
    private string GunName;
    private int shotRate;
    private int gunIndex = 0;
    private GameObject current3dmodel;
    private AudioSource shotsound;


    void Start()
    {
        shotsound = transform.GetComponent<AudioSource>();
        if (gundata != null)
            current3dmodel = Instantiate(gundata.model3Dprefab, transform.position, transform.rotation, transform);
        damage = gundata.damage;
        AmmoInMagazine = gundata.AmmoPerMagazine;
        NumOfMagazines = gundata.currentNumOfMagazines - 1; //one magazine is loaded
        GunName = gundata.GunName;
        shotRate = gundata.shotRate;

        shotsound.clip = gundata.shotsound;
        gameObject.GetComponent<Shooting>().changeAmmoText();
        
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
                AmmoInMagazine += gundata.AmmoPerMagazine;
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

    public void addMagazine()
    {
        Debug.Log("magazine added to ammo");
    }

}
