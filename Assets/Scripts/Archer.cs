using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string nome, int hp, int dmg) : base(nome, hp, dmg)
    {
    }

    public override void Attack()
    {
        for (int i = 0; i < 2; i++)
        {
            Debug.Log($"{GetNome()} attacca scagliando la {i+1}a freccia infliggendo {GetDmg()} di danno");
        }
        
    }  
    public override void TakeDamage(int damage)
    {
        SetHp(GetHp() - damage);
        Debug.Log($"{GetNome()} ha subito {damage} di danno");
    }


}
