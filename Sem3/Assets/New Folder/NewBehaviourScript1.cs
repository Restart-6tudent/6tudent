using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    static public int x, y, z, f;
    public GameObject First;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay(Collider other)
    {
        First.GetComponent<Renderer>().material.color = new Color32((byte)x, (byte)y, (byte)z, 1);
        First.gameObject.transform.Rotate(0, f, 0);
    }
}