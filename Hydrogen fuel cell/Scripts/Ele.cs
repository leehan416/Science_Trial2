using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ele : MonoBehaviour
{
    MainSystem syc;

    Rigidbody Rb;

    public Hydrogen Hy;
    
    public int b = 0;

    void Start()
    {
        syc = MainSystem.instance;
        Rb = GetComponent<Rigidbody>();

    }

    float power = 4f;

    private void Update()
    {
        if ( !syc.Ismobile )
        { 
            switch (b)  {
                case 0:
                    Rb.AddForce(power * -Vector3.forward * Time.deltaTime, ForceMode.Impulse);
                    break;
                case 1:
                case 2:
                    Rb.AddForce(power * -Vector3.right * Time.deltaTime, ForceMode.Impulse);
                    break;
                case 3:
                    Rb.AddForce(power * Vector3.forward * Time.deltaTime, ForceMode.Impulse);
                    break;
            
            }
        } else {
            switch (b)
            {
                case 0:
                    Rb.AddForce(power * -Vector3.right * Time.deltaTime, ForceMode.Impulse);
                    break;
                case 1:
                case 2:
                    Rb.AddForce(power * Vector3.forward * Time.deltaTime, ForceMode.Impulse);
                    break;
                case 3:
                    Rb.AddForce(power * Vector3.right * Time.deltaTime, ForceMode.Impulse);
                    break;

            }
        }
    }

    private void OnTriggerEnter()
    {
        b++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == syc.ForH3)
        {
            Hy.Ox.Check();
            Destroy(Hy.gameObject);
            Destroy(gameObject);
            
        }

    }
}
