using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 20;
    float height = 176.7f;
    string myName = "��μ�";
    bool canPlayFootball = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� " + myName + "�Դϴ�.");
        Debug.Log("���� " + age + "�� �Դϴ�.");
        Debug.Log("�� Ű�� " + height + "cm �Դϴ�.");
        Debug.Log("���� ǲ�� �÷��� ���δ� " + canPlayFootball + " �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
