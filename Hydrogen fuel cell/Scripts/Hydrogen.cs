using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : MonoBehaviour
{
    MainSystem syc;

    public Transform Tr;
    public Transform Nuc;
    public Transform Ele;
    public Ele EleA;
    public Oxygen Ox;

    bool Waiting = false;

    void Start()
    {
        syc = MainSystem.instance;
        Tr = GetComponent<Transform>();
        Nuc = Tr.Find("Nucleus");
        Ele = Tr.Find("Electron");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.collider == syc.ForH1)
        {
            Tr.position = syc.Spawn2.position;
            Ele.gameObject.SetActive(false);
            EleA = Instantiate(syc.Ele, syc.Spawn3).GetComponent<Ele>();
            EleA.Hy = this;
        }

    }
}
