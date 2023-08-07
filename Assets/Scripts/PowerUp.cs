using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float actSpeed;
    public float newSpeed;
    public bool activate=false;
    public float cooldown;
    public float time;
    public GameObject py;
     
    public void SpeedUp()
    {
        actSpeed = py.GetComponent<MoveController>().speed;
        //py.GetComponent<MoveController>().speed = newSpeed;
        activate = true;
        time = cooldown;


    }
    public void Update()
    {
        if (activate && time > 0)
        {
            time = time - Time.deltaTime;
            py.GetComponent<MoveController>().speed = newSpeed;
        }
        else
        {
            py.GetComponent<MoveController>().speed = actSpeed;
        }
    }
}
