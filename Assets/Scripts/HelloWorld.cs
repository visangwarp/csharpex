using UnityEngine;

public class HelloWorld : MonoBehaviour
{
  string name = "Hong";
  void Start()
  {
    int age;
    age = 1;
    Run();
    Debug.Log("START");
  }
 void Run ()
 {
 // 동작
 Debug.Log("RUN");
 }
}
