using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character 
{
    private string nome;
    private int hp;
    private int dmg;

    public abstract void Attack();
    public abstract void TakeDamage(int damage);

    public Character(string nome, int hp, int dmg)
    {
        SetNome(nome);
        SetHp(hp);
        SetDmg(dmg);
    }

    public string GetNome() => nome;
    public void SetNome(string nome) => this.nome = nome;
    public int GetHp() => hp;
    public void SetHp(int hp) => this.hp = hp;
    public int GetDmg() => dmg;
    public void SetDmg(int dmg) => this.dmg = dmg;
}


