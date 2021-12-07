using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShipInput))]
public class ShipEngine : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float turnSpeed = 5f;

    private ShipInput shipInput;
    private float lastThrust = float.MinValue;

    public event Action<float> ThrustChanged = delegate { };

    private void Awake()
    {
        shipInput = GetComponent<ShipInput>();
    }


    private void Update()
    {
        if (lastThrust != shipInput.Vertical)
            ThrustChanged(shipInput.Vertical);

        lastThrust = shipInput.Vertical;

        transform.position += Time.deltaTime * shipInput.Vertical * transform.forward * speed;
        transform.Rotate(Vector3.up * shipInput.Horizontal * turnSpeed * Time.deltaTime);

    }
}
