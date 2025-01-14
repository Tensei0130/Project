using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Header("移動速度")]
    float speed = 5f;

    [SerializeField, Header("回転速度")]
    float rotateSpeed = 5f;

    [SerializeField, Header("アニメーター")]
    Animator animator;

    //[SerializeField, Header("距離")]
    //Vector3 direction;

    [SerializeField, Header("水平方向")]
    float horizontal;

    [SerializeField, Header("縦方向")]
    float vertical;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //水平方向の入力
        horizontal = Input.GetAxisRaw("Horizontal");

        //縦方向
        vertical = Input.GetAxisRaw("Vertical");

        //入力していた場合
        if (vertical != 0)
        {
            //加算
            transform.position += transform.forward * speed * vertical * Time.deltaTime;

            //アニメーションを切り替える
            animator.SetBool("walk", true);
        }
        else
        {
            //アニメーションを切り替える
            animator.SetBool("walk", false);
        }

        transform.Rotate(new Vector3(0, rotateSpeed * horizontal, 0));

    }
}