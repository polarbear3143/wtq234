using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{

    public Stat()
    {
        Debug.Log("Stat 생성");
    }
}
public class player : MonoBehaviour
{
    #region 접근 지정자
    //클래스 내부의 포함되어 있는 속성에 접근 범위를
    // 제한하는 지정자입니다.
    Stat stat = new Stat();
    //public
    //클래스 내부와 자기가 상속하고 있는 클래스 그리고
    // 클래스 외부에서도 접근을 허용하는 지정자입니다.
    public int health;

    // private 
    // 클래스 내부에서만 접근을 허용하는 지정자입니다.
    private float speed;

    // 접근 지정자를 선언하지 않으면 기본 접근 지정자(private)로 설정됩니다.
    Vector3 direction;

    #endregion

    // start( ) : 게임 오브젝트가 생성되었을 때, 단 한 번만 호출되며
    //            스크립트가 비활성화되었을 땐 호출되지 않습니다.
    private void Start()
    {

        speed = 5.0f;

    }
    // start ( ) : 매 프레임마다 실해오디는 이벤트 함수입니다.
    private void Update()
    {
        //p0 : 현재 위치
        //v : 방향과 크기
        //t : 시간
        //P = P0 + vt
        // Input.GetAxis : -1 ~ 1 사이의 값을 반환하는 함수입니다.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // 벡터의 정규화
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
