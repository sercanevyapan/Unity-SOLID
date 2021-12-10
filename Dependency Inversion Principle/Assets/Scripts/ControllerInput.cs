using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : IShipInput
{
    public float Rotation { get; private set; }

    public float Thrust { get; private set; }

    public void ReadInput()
    {
        Rotation = Input.GetAxis("Horizontal");
        Thrust = Input.GetAxis("Vertical");
    }
}
