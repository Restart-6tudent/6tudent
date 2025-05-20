using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class A : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    public void AWork()
    {
        obj.transform.Rotate(0f, 0f, 90f);
    }
}
