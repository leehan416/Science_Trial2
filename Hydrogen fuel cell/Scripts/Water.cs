using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    MainSystem syc;
    public Transform Tr;

    void Start()
    {
        syc = MainSystem.instance;
        Tr = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == syc.ForH4)
        {
            Tr.position = syc.Spawn6.position;
        }

    }
}
