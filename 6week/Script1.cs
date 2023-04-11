using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    float inch = 12.5f; // inch 변수 선언 및 값 지정
    float cm = 30.48f; // cm 변수 선언 및 값 지정

    // Start is called before the first frame update
    void Start()
    {
        // inch와 cm 값 출력
        Debug.Log("inch: " + inch);
        Debug.Log("cm: " + cm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

