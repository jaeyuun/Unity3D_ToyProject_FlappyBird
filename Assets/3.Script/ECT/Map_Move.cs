using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//생성된 파이프가 움직이는 코드
public class Map_Move : MonoBehaviour
{
    private float position_X;//포지션설정
    private float Speed = 5f; //움직이는 스피드
    private void FixedUpdate()
    {
        position_X = transform.position.x + (Speed * Time.fixedDeltaTime)*-1;
        transform.position = new Vector3(position_X, transform.position.y, 0f);
    }
}
