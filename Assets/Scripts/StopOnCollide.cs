using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StopOnCollide : MonoBehaviour
{
    private MoveRight script;
    private Rigidbody knifeBody;
    //public float radius = 1000.0f;
    //public float power = 1000.0f;
    private bool knifeCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
            script = GetComponent<MoveRight>();
            Destroy(script);
        
        if (collision.gameObject.CompareTag("Wheel") && !knifeCollided)
        {
            knifeBody = GetComponent<Rigidbody>();
            Destroy(knifeBody);
            gameObject.transform.parent = collision.gameObject.transform;

        } else if (collision.gameObject.CompareTag("Knife"))
        {
            knifeCollided = true;
            if(GetComponent<Rigidbody>() != null)
                GetComponent<Rigidbody>().useGravity = true;
    
            GameObject wheel = GameObject.Find("Wheel");
            if (wheel != null && wheel.GetComponent<Rigidbody>() == null) { 
                wheel.AddComponent<Rigidbody>();
            }

            wheel.GetComponent<RotateWheel>().enabled = true;

        }
    }

}
