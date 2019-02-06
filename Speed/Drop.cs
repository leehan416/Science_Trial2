using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Drop : MonoBehaviour {



    public GameObject Camera_Main;
    public GameObject Camera_Sky;
    public GameObject Camera_Black;

    void Start() {
        Down();
        this.GetComponent<Dropdown>().captionText.text = "Cam";
    }

    public void Down() {
        List<string> list = new List<string> { "Main_Cam", "Sky_Cam", "Black_Cam" };
        this.GetComponent<Dropdown>().AddOptions(list);
    }
    public void Indexer(int Val) {
        Cut(Val);
    }
    
    void Cut(int a) {
        switch (a) {
            case 0: // MCamera
                Move.instance.CamNum = 0;
                Camera_Sky.SetActive(false);
                Camera_Black.SetActive(false);
                Camera_Main.SetActive(true);
                break;
            case 1: //SCamera
                Move.instance.CamNum = 1;
                Camera_Main.SetActive(false);
                Camera_Black.SetActive(false);
                Camera_Sky.SetActive(true);
                break;
            case 2: //BCamera        
                Move.instance.CamNum = 2;
                Camera_Main.SetActive(false);
                Camera_Sky.SetActive(false);
                Camera_Black.SetActive(true);
                break;
        }

    }
}
