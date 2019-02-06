using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveMent : MonoBehaviour {


    public static MoveMent instance;

    public Rigidbody Cube_Data;
    public Rigidbody Cube;
    public Rigidbody Moving;

    public float Up = 100f;
    public float Speed = .3f;
    public bool C = false;
    private void Awake() {
        Cube = Instantiate(Cube_Data);
        if (!instance) { instance = this; }
        else { DestroyImmediate(this); }
    }//123


    void Update() {
        Moving.AddForce(Vector3.right * 1000 * Speed, ForceMode.Impulse);
        if ( Moving.position.x >=50f )
        {
            Moving.position -= Vector3.right * 50f;

        }
    }
    public void Jump() {
        if (C) {
            C = false;
            Cube.AddForce(Vector3.up * Up, ForceMode.Impulse);
        }
    }
}
