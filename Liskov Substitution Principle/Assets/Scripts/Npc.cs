using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Character
{
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount *5);
    }
}
