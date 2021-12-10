using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShipInput 
{
    void ReadInput();
    float Rotation { get; }
    float Thrust { get; }
}
