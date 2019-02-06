using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    Transform Tr;
    public GameObject Light;
    public Light light;

    float time = 0f;

    void Start()
    {
        Tr = GetComponent<Transform>();
        Light = Tr.Find("Light").gameObject;
        light = Light.GetComponentInChildren<Light>();

        Light.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (time <= 0f)
        {
            time += 0.4f;
            StartCoroutine(Flash());
            return;
        }
        if ( time + 0.25f <= 3f) { time += 0.25f; }
    }

    IEnumerator Flash()
    {
        while (time > 0f)
        {

            Light.SetActive(true);
            light.intensity = time * 4f;
            time -= Time.deltaTime;
            yield return null;

        }
        time = 0f;
        Light.SetActive(false);
        yield return null;
    }

}
