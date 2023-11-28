using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Nullable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int? a = null;

        Debug.Log(a.HasValue);
        Debug.Log(a != null);

        a = 3;

        Debug.Log(a.HasValue);
        Debug.Log(a != null);
        Debug.Log(a.Value);  
    }
    
    
    
       {  var a = 20;
        Debug.Log($"Type: {a.GetType()}, Value: {a}");
        var b = 3.1414213;
        Debug.Log($"Type: {b.GetType()}, Value: {b}");
        var c = "Hello World";
        Debug.Log($"Type: {c.GetType()}, Value: {c}");
        var d = new int[]{10,20,30};
        foreach (var e in d)
            Debug.Log(e);
            }
        }
    }
 
}
