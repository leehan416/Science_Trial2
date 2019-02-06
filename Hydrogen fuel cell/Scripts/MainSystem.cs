using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
    public static MainSystem instance;

    public GameObject Ele;
    public GameObject Hy;
    public GameObject Ox;
    public GameObject Water;

    public bool Ismobile = false;

    public Collider ForH1;
    public Collider ForH2;
    public Collider ForH3;
    public Collider ForH4;

    public Transform Spawn1;
    public Transform Spawn1_1;
    public Transform Spawn2;
    public Transform Spawn3;
    public Transform Spawn4;
    public Transform Spawn5;
    public Transform Spawn6;



    private void Awake()
    {
        
        if(!instance)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
        Time.timeScale = 1.5f;
    }
}
