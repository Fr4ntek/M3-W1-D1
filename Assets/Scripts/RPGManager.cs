using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character[] characters = new Character[3];
        characters[0] = new Warrior("JinWoo", 100, 10);
        characters[1] = new Mage("Merlin", 100, 12);
        characters[2] = new Archer("Legolas", 100, 7);

        for (int i = 0; i < characters.Length; i++)
        {
            Debug.Log($"{characters[i].GetNome()}: {characters[i].GetHp()} HP prima dell'attacco");
            characters[i].Attack();
            Debug.Log($"{characters[i].GetNome()}: {characters[i].GetHp()} HP dopo l'attacco");

            Debug.Log($"{characters[i].GetNome()}: {characters[i].GetHp()} HP prima di prendere danno");
            characters[i].TakeDamage(Random.Range(1, 21));
            Debug.Log($"{characters[i].GetNome()}: {characters[i].GetHp()} HP dopo aver preso danno");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
