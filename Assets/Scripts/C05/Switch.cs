using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string day = "��";
        switch (day)
        {
            case "��":   
                Debug.Log("Sunday");
                break;
            case "��":
                Debug.Log("Monday");
                break;
            case "ȭ":
                Debug.Log("Tuesday");
                break;
            case "��":
                Debug.Log("Wednesday");
                break;
            case "��":
                Debug.Log("Thursday");
                break;
            case "��":
                Debug.Log("Friday");
                break;
            case "��":
                Debug.Log("Saturday");
                break;
            default:
                Debug.Log($"{day}��(��) ������ �ƴմϴ�.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
