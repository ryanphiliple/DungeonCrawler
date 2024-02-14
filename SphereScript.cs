using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Secret Number = " + MySingleton.secretNumber);
        print("inside first room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
