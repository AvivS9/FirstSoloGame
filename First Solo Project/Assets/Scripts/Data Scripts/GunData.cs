using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun Data", menuName = "Weapons")]
public class GunData : ScriptableObject
{

    public int damage;
    public int AmmoPerMagazine;
    public int MaxNumOfMagazines;
    public string GunName;
    public float range = 100f;

    public Sprite icon;

    public int shotRate;




}
