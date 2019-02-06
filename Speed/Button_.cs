using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_ : MonoBehaviour {

    public GameObject Canvas;
    public GameObject Canvas2;





    void Start() {
        Canvas.SetActive(true);
        Canvas2.SetActive(false);
    }

    public void Button___() {
        Time.timeScale = 1;
        Move.instance.Call();
        Canvas.SetActive(false);
        Canvas2.SetActive(true);

    }
    public void Re() {
        SceneManager.LoadScene("Speed");
    }
}
