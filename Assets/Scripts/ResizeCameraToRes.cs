using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeCameraToRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographicSize = 8.0f * Screen.width / Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
