using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cu : MonoBehaviour {

    public Transform Camera;

    public float CameraHeight = 22f;

    void OnCollisionEnter(Collision collision) {
        MoveMent.instance.C = true;
    }

    void Update() {
        
        if (MoveMent.instance.Cube.transform.position.x >= 3.0f) {

            MoveMent.instance.Cube.transform.position -= Vector3.right * 143.0f;

            //Destroy(gameObject);
            //MoveMent.instance.Cube = Instantiate(MoveMent.instance.Cube_Data, Vector3.right * -130f + Vector3.up * 1f, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Space");
            MoveMent.instance.Jump();
        }
    }

    private void LateUpdate() {
        Camera.position = ( Vector3.forward * Camera.position.z ) + ( Vector3.up * CameraHeight ) + (Vector3.right * Camera.position.x);
    }


}
