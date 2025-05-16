using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaMagica : Proiettile
{
    public override void Lancia()
    {
        Debug.Log("La palla magica è stata lanciata a " + GetSpeed() + " km/h");
    }

    public PallaMagica(float speed)
    {
        SetSpeed(speed);
    }
}
