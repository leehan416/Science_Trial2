using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    void Update() {
        if (Controller.instance.ok) {
            if (!(Input.GetKey(KeyCode.RightShift))) {
                return;
            }
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        if (Input.GetKey(KeyCode.Space)) {
            transform.Translate(0, Time.deltaTime*10, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift)) {
            transform.Translate(0, -Time.deltaTime*10, 0);
        }
        transform.Translate(x, 0, z);
    }



}
