using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    int age = 20;
    float height = 176.7f;
    string myName = "김민서";
    bool canPlayFootball = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("나는 " + myName + "입니다.");
        Debug.Log("나는 " + age + "살 입니다.");
        Debug.Log("내 키는 " + height + "cm 입니다.");
        Debug.Log("나의 풋볼 플레이 여부는 " + canPlayFootball + " 입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
