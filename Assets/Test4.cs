using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    [SerializeField] bool isPlayingGuitar;
    [SerializeField] int age;

    // Start is called before the first frame update
    void Start()
    {
        if(isPlayingGuitar == true)
        {
            Debug.Log("기타 연주 중 띵띵띵 땅땅땅");
        }
        else
        {
            Debug.Log("기타 연주 안 함.");
        }

        if (age == 20)
        {
            Debug.Log("대학교 신입생이구만");
        }
        else if (age >= 21)
        {
            Debug.Log("신입생이 아니시네요");
        }
        else Debug.Log("어린노무셰끼");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
