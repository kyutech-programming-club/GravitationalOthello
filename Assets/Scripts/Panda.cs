using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panda : MonoBehaviour
{
    public GameObject panda1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButtonPanda() {
        panda1.transform.Rotate(new Vector3(0, 0, 5));
    }
}
