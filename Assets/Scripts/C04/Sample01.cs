using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int i = 0;
       int j = 1;
       
        bool b1 = true;
        bool b2 = false;

        if (i > j)
        {
            Debug.Log("i�� j���� ŭ!");
        }
        if (j> i)
        {
            Debug.Log("j�� i���� ŭ!");
        }
    }

 
}
