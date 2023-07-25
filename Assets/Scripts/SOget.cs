using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOget : MonoBehaviour
{
    [SerializeField] SOweapon wapon;
    private void Update()
    {
        Debug.Log(wapon.Nombre);
        Debug.Log(wapon.descripcion);
        Debug.Log(wapon.melee);
        Debug.Log(wapon.damage);
        Debug.Log(wapon.DropRate);
    }
}
