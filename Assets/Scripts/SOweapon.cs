using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName ="SOweapon")] 

public class SOweapon : ScriptableObject
{
    public string Nombre;
    public string descripcion;
    public bool melee;
    public float damage;
    public string DropRate;
}
