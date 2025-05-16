using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freccia : Proiettile
{
    public override void Lancia()
    {
        Debug.Log("La freccia è stata lanciata a " + GetSpeed() + " km/h");
    }

    public Freccia(float speed)
    {
        SetSpeed(speed);
    }
}
