using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonControlleer : MonoBehaviour {
    string a, b, c;
    float a1, b1, c1;

    public void StartButton() {
        a = Controller.instance.text1.text;
        b = Controller.instance.text2.text;
        c = Controller.instance.text3.text;
        if (a.Trim() == "") {
            a1 = 9.8f;
        } else {
            a1 = Convert.ToInt32(a);
        }
        if (b == "") {
            b1 = 1f;
        } else {
            b1 = Convert.ToInt32(b);
        }
        if (c == "") {
            c1 = 0f;
        } else {
            c1 = Convert.ToInt32(c);
        }
         Controller.instance.Start_Button(a1,b1,c1);
    }

    public void MoveScene(string SceneName) {
        SceneManager.LoadScene(SceneName);

    }
}
