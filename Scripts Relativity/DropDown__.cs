using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDown__ : MonoBehaviour {

    public GameObject MCam;
    public GameObject CCam;

    void Start() {
        Down();
        CCam = MoveMent.instance.Cube.GetComponent<Cu>().Camera.gameObject;
        this.GetComponent<Dropdown>().captionText.text = "Cube_Cam";
    }

    public void Down() {
        List<string> list = new List<string> { "Main_Cam", "Cube_Cam" };
        this.GetComponent<Dropdown>().AddOptions(list);
    }
    public void Indexer(int Val) {
        Kal (Val);
    }
    void Kal(int a) {
        switch (a) {
            case 0:
                CCam.SetActive(false);
                MCam.SetActive(true);
                break;
            case 1:
                CCam.SetActive(true);
                MCam.SetActive(false);
                break;
        }
    }


}
