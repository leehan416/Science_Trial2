using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingController : MonoBehaviour
{

    Rigidbody Rb;

    public float Speed = 10f;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    Vector3 movement;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        bool Space = Input.GetKeyDown(KeyCode.Space);

        movement.Set(-x, 0f, -y);

        movement = movement.normalized * Speed * Time.deltaTime;

        Rb.AddForce(movement,ForceMode.Impulse);

        if (Space == true) { Rb.AddForce(Vector3.up * 10f, ForceMode.Impulse); }

    }
}
