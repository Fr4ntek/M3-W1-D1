using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    
    public Warrior(string nome, int hp, int dmg) : base(nome, hp, dmg)
    {
    }

    public override void Attack()
    {
        Debug.Log($"{GetNome()} attacca infliggendo {GetDmg()} di danno");
    }

    public override void TakeDamage(int damage)
    {
        SetHp(GetHp() - damage);
        Debug.Log($"{GetNome()} ha subito {damage} di danno");
    }

}
