using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("�߱�");
        a?.Add("�౸");
        Debug.Log($"Count : {a?[0]}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        a = new ArrayList();

        a?.Add("�߱�");
        a?.Add("�౸");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"{a?[0]}");
        Debug.Log($"{a?[1]}");

        Person person = new Person();

    }



}

public class Person
{
    //���� �� ����
    int age;

    // �Լ�  ����
    public +void walk()
    {

    }
}
 