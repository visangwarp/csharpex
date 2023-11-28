using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        String greeting = "Good Morning";
        Debug.Log(greeting);

       // IndexOf()
        Debug.Log($"IndexOf: 'Good' : { greeting.IndexOf("Good")}");
        Debug.Log($"IndexOf 'o' : { greeting.IndexOf('o')}");

       // LastIndexOf()
        Debug.Log($"LastIndexOf 'Good' : { greeting.LastIndexOf("Good")}");
        Debug.Log($"LastIndexOf 'g' : { greeting.LastIndexOf("g")}");
      
      // StartWith()
        Debug.Log($"StartWith 'Good' : { greeting.StartWith("Good")}");
        Debug.Log($"StartWith 'g' : { greeting.StartWith("Morning")}");
      
       // EndstWith()
        Debug.Log($"EndsWith 'Good' : { greeting.EndsWith("Good")}");
        Debug.Log($"EndsWith 'Morning' : { greeting.EndsWith("Morning")}");

        // Contains()
        Debug.Log($"Contains 'Evening' : { greeting.Contains("Evening")}");
        Debug.Log($"Contains 'Morning' : { greeting.Contains("Morning")}");

         // Replace()
        Debug.Log($"Replace 'Morning' with 'Evening': { greeting.Replace("Morning","Evening")}");

       )
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
