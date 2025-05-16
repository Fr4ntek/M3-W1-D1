using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Esercizio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Proiettile[] proiettili = new Proiettile[2];
        proiettili[0] = new Freccia(2f);
        proiettili[1] = new PallaMagica(8f);

        for (int i = 0; i < proiettili.Length; i++)
        {
            proiettili[i].Lancia();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
