using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Ship/Settings", fileName ="ShipData")]
public class ShipSettings : ScriptableObject
{
    [SerializeField] private float turnSpeed = 25f;
    [SerializeField] private float moveSpeed = 25f;
    [SerializeField] private bool useAi = false;

    public float TurnSpeed { get { return turnSpeed; } }
    public float MoveSpeed { get { return moveSpeed; } }
    public bool UseAi { get { return useAi; } }
}
