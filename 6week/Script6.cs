using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script6 : MonoBehaviour
{
        public float inch; // 인치를 저장할 멤버 변수

    // 인치를 센티미터로 변환하는 메서드
    public float ConvertToCm()
    {
        float cm = inch * 2.54f; // 1인치는 2.54 센티미터
        return cm;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        float cm = ConvertToCm(); // 인치를 센티미터로 변환
        Debug.Log(inch + "인치는 " + cm + "센티미터입니다."); // 변환 결과를 로그로 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}