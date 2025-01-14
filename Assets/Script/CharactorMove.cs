using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Animator animator; // アニメーターコンポーネントへの参照
    public float rotationAngle = 90.0f; // プレイヤーが回転する角度

    void Start()
    {
        // アニメーターコンポーネントを取得
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // キー入力に応じてプレイヤーの回転とアニメーションを制御する
        if (Input.GetKeyDown(KeyCode.W))
        {
            RotateAndAnimate(0f); // 上キーが押されたとき、プレイヤーを前方に回転させる
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RotateAndAnimate(-rotationAngle); // 左キーが押されたとき、プレイヤーを左に回転させる
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            RotateAndAnimate(-180f); // 下キーが押されたとき、プレイヤーを後方に回転させる
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RotateAndAnimate(rotationAngle); // 右キーが押されたとき、プレイヤーを右に回転させる
        }

        // wasdキーが離された瞬間に歩行アニメーションを停止する
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("walk", false); // 歩行アニメーションを停止
        }
    }

    // プレイヤーの回転と歩行アニメーションの制御
    void RotateAndAnimate(float angle)
    {
        transform.rotation = Quaternion.Euler(0f, angle, 0f); // プレイヤーを指定された角度に回転させる
        animator.SetBool("walk", true); // 歩行アニメーションを開始
    }
}