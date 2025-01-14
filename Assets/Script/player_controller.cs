using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Header("�ړ����x")]
    float speed = 5f;

    [SerializeField, Header("��]���x")]
    float rotateSpeed = 5f;

    [SerializeField, Header("�A�j���[�^�[")]
    Animator animator;

    //[SerializeField, Header("����")]
    //Vector3 direction;

    [SerializeField, Header("��������")]
    float horizontal;

    [SerializeField, Header("�c����")]
    float vertical;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //���������̓���
        horizontal = Input.GetAxisRaw("Horizontal");

        //�c����
        vertical = Input.GetAxisRaw("Vertical");

        //���͂��Ă����ꍇ
        if (vertical != 0)
        {
            //���Z
            transform.position += transform.forward * speed * vertical * Time.deltaTime;

            //�A�j���[�V������؂�ւ���
            animator.SetBool("walk", true);
        }
        else
        {
            //�A�j���[�V������؂�ւ���
            animator.SetBool("walk", false);
        }

        transform.Rotate(new Vector3(0, rotateSpeed * horizontal, 0));

    }
}