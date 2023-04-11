using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          int sum = 0; // 합을 저장할 변수

        // 반복문을 사용하여 1부터 10까지의 숫자를 더함
        for (int i = 1; i <= 10; i++)
        {
            sum += i; // 현재 숫자를 합에 더함
        }

        Debug.Log("1부터 10까지의 합: " + sum); // 합을 로그로 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
