using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 55f;
    public Vector3 direction;

    private void Start()
    {
        direction = transform.position;

        //첫 번째 매개변수 : 호출할 함수의 이름
        //두 번째 매개변수 : 몇 초 뒤에 실행할 시간
        //세 번째 매개변수 : 몇 초 마다 반복되는 시간
        InvokeRepeating("NewPosition", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
           Vector3.forward * speed * Time.deltaTime
            );   
    }

    public void NewPosition()
    {
        transform.position = direction;
        transform.Find("Canvas").gameObject.SetActive(false);
    }
}
