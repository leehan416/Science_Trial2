using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Controller : MonoBehaviour {

    public static Controller instance;
    public Rigidbody Object_1;
    public Rigidbody Object_2;

    public GameObject Con;
    public GameObject Con2;


    public Text text1;
    public Text text2;
    public Text text3;

    public Text V1;
    public Text V2;

    float H1;
    float H2;

    public bool ok;

    void Start() {
        ok = false;
        if (!instance) { instance = this; }
        else { DestroyImmediate(this); }
        Con.SetActive(!false);
        Con2.SetActive(!true);
        Physics.gravity = -Vector3.up*0;
    }
    public void Start_Button(float Gravity,float Value_1,float Right) {
        

        ok = true;
        Con.SetActive(false);
        Con2.SetActive(true);
        Object_1.mass = Value_1;
        if (Right < 0) {
            Right *= -1;
        }
        Object_1.AddForce(Vector3.right * 5 * -Right, ForceMode.Impulse);
        Physics.gravity -= Vector3.up  * Gravity;

    }
    void Update() {
        if (ok) {

            H1 = Object_1.position.y;
            H2 = Object_2.position.y; 
            V1.text = Convert.ToString(H1);
            Debug.Log(H1);
            V2.text = Convert.ToString(H2);
            Debug.Log(H2);
            return;
        } else {
            return;
        }    
    }

    /*
    public void Function(float V,float Gravity) {

        for (int time = 0;time != 10 ; time++) { // 속도 그래프
            V += time * Gravity;
            Instantiate(,V,)
        }
    }*/



}
