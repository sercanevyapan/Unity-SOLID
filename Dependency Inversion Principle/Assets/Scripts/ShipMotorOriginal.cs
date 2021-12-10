using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotorOriginal : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private float moveSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float thrust = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * rotation * Time.deltaTime * turnSpeed);
        transform.position += transform.forward * thrust * Time.deltaTime * moveSpeed;
    }
}
