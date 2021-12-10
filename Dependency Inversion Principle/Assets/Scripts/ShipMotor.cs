using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotor : MonoBehaviour
{
    private readonly IShipInput shipInput;
    private readonly Transform transformToMove;
    private readonly ShipSettings shipSettings;


    private float turnSpeed = 25f;
    private float moveSpeed = 10f;

    public ShipMotor(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings)
    {
        this.shipInput = shipInput;
        this.transformToMove = transformToMove;
        this.shipSettings = shipSettings;
    }

    public void Tick()
    {
        transformToMove.Rotate(Vector3.up * shipInput.Rotation * Time.deltaTime * shipSettings.TurnSpeed);
        transformToMove.position += transformToMove.forward * shipInput.Thrust * Time.deltaTime * shipSettings.MoveSpeed;
    }
}
