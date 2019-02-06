using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Supply : MonoBehaviour
{

    MainSystem syc;

    public Button SupplyButton;
    public InputField SupplyAmount;
    public Slider Timeline;

    private void Start()
    {
        SupplyButton = GetComponentInChildren<Button>();
        SupplyAmount = GetComponentInChildren<InputField>();
        Timeline = GetComponentInChildren<Slider>();
        
        SupplyButton.onClick.AddListener(Clicked);

        Timeline.onValueChanged.AddListener(ChangeTime);

        syc = MainSystem.instance;
    }

    void Clicked() {
        StopAllCoroutines();
        StartCoroutine(Suppling( Convert.ToInt32(SupplyAmount.textComponent.text) ) );
    }

    WaitForSeconds time = new WaitForSeconds(0.4f);

    Oxygen tmp;

    IEnumerator Suppling(int amount = 1)
    {
        while (amount > 0)
        {
            yield return time;
            tmp = Instantiate(syc.Ox, syc.Spawn4).GetComponent<Oxygen>();
            tmp.H1 = Instantiate(syc.Hy, syc.Spawn1_1);
            tmp.H2 = Instantiate(syc.Hy, syc.Spawn1);
            tmp.check();
            amount--;
        }
    }

    void ChangeTime( float time = 1.5f )
    {
        Time.timeScale = time;
    }

}
