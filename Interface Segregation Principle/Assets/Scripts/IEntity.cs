using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity 
{
    //BuffController BuffController { get; }
    void Mesmerize(IEntity ownerEntity);
    int STR { get; }
    int STA { get; }
    int CON { get; }
    int WIS { get; }
    int INT { get; }
    int CHA { get; }
    //FloatStack<object> AttackSpeedStack { get; }

    int Health { get; set; }
    int HealthMax { get; }
    int ModifyHealth(int amount);
    //DamageShieldController DamageShieldController { get; }

}

public class AttackProcessor
{

    public void ProcessMelee(IHaveStats attacker, IHaveHealth target)
    {
        int amount = CalculateAttackAmount(attacker);
        ProccessAttack(target, amount);
    }

    public int CalculateAttackAmount(IHaveStats attacker)
    {
        return attacker.STR * 2;
    }
    public void ProccessAttack(IHaveHealth target,int amount)
    {
        target.ModifyHealth(amount);
    }
}

public class NPC : IHaveStats
{
    public int STR { get; }
    public int STA { get; }
    public int CON { get; }
    public int WIS { get; }
    public int INT { get; }
    public int CHA { get; }
    //FloatStack<object> AttackSpeedStack { get; }

    public int Health { get; set; }
    public int HealthMax { get; }
    public int ModifyHealth(int amount)
    {
        return amount;
    }
}

public class Door : IHaveHealth
{
    public int Health { get; set; }

    public int HealthMax { get; }


    public int ModifyHealth(int amount)
    {
        Health -= amount;
        return Health;
    }

}

/// <summary>
/// /////////////////////////////////////
/// </summary>
public interface IHaveBuffs
{
    //BuffController BuffController { get; }
}

public interface ICanBeMesmerized
{
    void Mesmerize(IEntity ownerEntity);
}

public interface IHaveStats : IHaveHealth
{
   public int STR { get; }
    public int STA { get; }
    public int CON { get; }
    public int WIS { get; }
    public int INT { get; }
    public int CHA { get; }
    //FloatStack<object> AttackSpeedStack { get; }
}

public interface IHaveHealth
{
    public int Health { get; set; }
    public int HealthMax { get; }
    public int ModifyHealth(int amount);
}

public interface IHaveDamageShield
{
    //DamageShieldController DamageShieldController { get; }
}

