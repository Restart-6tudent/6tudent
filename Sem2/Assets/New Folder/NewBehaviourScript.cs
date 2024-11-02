using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Test;
    public int x = 0;
    public Text Mytxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        Mytxt.text = x.ToString();
        if (x >= 500)
           Test.SetActive(false);
    }
}
