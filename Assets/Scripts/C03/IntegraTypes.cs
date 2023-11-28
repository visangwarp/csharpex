using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace C0301
{
public class IntegraTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     {
        sbyte a = -10;
     byte b = 40;

     Debug.Log($"a=(a), b=(b)");

     short c = -3000;
     ushort d = 6000;

     Debug.Log($"c= {c}, d=(d)");

     int e = -1000_0000; // 0이 7개
     uint f = 3_0000_0000; //  0이 8개

     Debug.Log($"e=(e), f-=(f)");  

     long g  = -5000_0000_000; // 0이 10개
     ulong h = 200_0000_0000_0000_0000; // 0이 18개

     Debug.Log($"g=(g), h=(h)");

     Debug.Log(string.Format("g={0}, h={1}", g, h));
     }
   // ---
     {
     byte a  = 255;
     sbyte b = (sbyte)a;

     Debug.Log(a);
     Debug.Log(b);
     }
     {
        uint a = uint.MaxValue;

        Debug.Log(a);
        a = a + 1;

        Debug.Log(a); 
     } 
     {
        float a = 3.13159265358979323846f;
        Debug.Log(a);
        double b = 3.13159265358979323846;
        Debug.Log(b);
     }
     }
   }


}
