using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Accion : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Presiono boton ");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Dejo de presionar el boton");
        }
    }

}
