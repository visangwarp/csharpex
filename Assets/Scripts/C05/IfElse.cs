using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IfElse : MonoBehaviour
{
    //
    public TMP_Text text;
     //
    public TMP_InputField inputfield; 

    // ��ư�� Ŭ�� �Ǿ����� ������ �Լ�
    public void ButtonClicked()
    {
        string input = inputfield.text;
        int number = int.Parse(input);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        string input = inputfield.text;
        int number = int.Parse(input);
       
        if (number < 0)
        {
            text.text = "����";

        }
        else if (number > 0)
        {
            text.text = "���";
        }
        else
        {
            text.text = "0";

        }
        if (number % 2 == 0)
        {
            text.text = "¦��";
        }
        else
        {
            text.text = "Ȧ��";

        }
    }
    }
