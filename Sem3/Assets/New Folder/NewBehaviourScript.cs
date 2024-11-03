using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject First;
    public int x = 0;
    public Text Mytxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewBehaviourScript1.x = UnityEngine.Random.Range(0, 255);
        NewBehaviourScript1.y = UnityEngine.Random.Range(0, 255);
        NewBehaviourScript1.z = UnityEngine.Random.Range(0, 255);
        NewBehaviourScript1.f = UnityEngine.Random.Range(0, 360);
        if (x > 0)
        {
            Mytxt.text = x.ToString();
            x++;
        }
        if (x > 333)
            First.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (x == 0)
            x++;
    }
}
