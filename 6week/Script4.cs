using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public int score; // 점수 변수 선언

    // Update is called once per frame
    void Start()
    {
        // 사용자로부터 점수 값을 입력받음
      
            if (score >= 80)
            {
                Debug.Log("우수");
            }
            else if (score >= 60)
            {
                Debug.Log("보통");
            }
            else
            {
                Debug.Log("미흡");
            }
        }
    }

