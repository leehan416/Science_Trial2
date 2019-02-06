using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen : MonoBehaviour
{
    MainSystem syc;

    public GameObject H1;
    public GameObject H2;

    public Hydrogen h1;
    public Hydrogen h2;
    public int index = 0;
    public void check()
    {
        syc = MainSystem.instance;
        h1 = H1.GetComponent<Hydrogen>();
        h2 = H2.GetComponent<Hydrogen>();

        h1.Ox = this;
        h2.Ox = this;
    }

    public void Check()
    {
        index++;
        if ( index >= 2 )
        {
            Destroy(gameObject);
            Instantiate(syc.Water, syc.Spawn5);

        }
    }

}
