using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crush : MonoBehaviour {
    void OnCollisionEnter(Collision other) {
        Controller.instance.ok = false;
    }
}
