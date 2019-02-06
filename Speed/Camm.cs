using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camm : MonoBehaviour {

    public GameObject Black;
    public GameObject Sky;
    public Camera cam;


    private void LateUpdate() {
        switch (Move.instance.CamNum) {
            case 1:
                cam.transform.rotation = Quaternion.LookRotation(Black.transform.position - cam.transform.position);
                break;
            case 2:
                cam.transform.rotation = Quaternion.LookRotation(Sky.transform.position - cam.transform.position);
                break;
        }
        return;
    }
}
