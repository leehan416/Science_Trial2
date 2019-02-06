using UnityEngine;
using System;
using UnityEngine.UI;
public class Move : MonoBehaviour {

    public static Move instance;

    public Text Out;
    
    public Text Text_B_Speed;
    public Text Text_S_Speed;

    public GameObject Black;
    public GameObject Sky;

    public int CamNum;

    public float SpeedK;
    public float speed_B = 0;
    public float speed_S = 0;
    void Start() {
        if (!instance) { instance = this; }
        else { DestroyImmediate(this); }
        Time.timeScale = 0;
    }
    void Update() {
        switch (CamNum) {
            case 0:
                SpeedK = 0;
                break;
            case 1:
                SpeedK = -speed_B - speed_S;
                break;
            case 2:
                SpeedK = -speed_B - speed_S;
                break;
        }
        Out.text = Convert.ToString(SpeedK);
        Sky.transform.Translate(0, 0, 1 * speed_S * Time.deltaTime);
        Black.transform.Translate(0, 0, 1 * speed_B * Time.deltaTime);
    }
    public void Call() {
        speed_B = Convert .ToInt32( Text_B_Speed.text);
        speed_S = Convert .ToInt32( Text_S_Speed.text);

    } 
}
