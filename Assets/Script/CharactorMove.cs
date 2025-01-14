using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Animator animator; // �A�j���[�^�[�R���|�[�l���g�ւ̎Q��
    public float rotationAngle = 90.0f; // �v���C���[����]����p�x

    void Start()
    {
        // �A�j���[�^�[�R���|�[�l���g���擾
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // �L�[���͂ɉ����ăv���C���[�̉�]�ƃA�j���[�V�����𐧌䂷��
        if (Input.GetKeyDown(KeyCode.W))
        {
            RotateAndAnimate(0f); // ��L�[�������ꂽ�Ƃ��A�v���C���[��O���ɉ�]������
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RotateAndAnimate(-rotationAngle); // ���L�[�������ꂽ�Ƃ��A�v���C���[�����ɉ�]������
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            RotateAndAnimate(-180f); // ���L�[�������ꂽ�Ƃ��A�v���C���[������ɉ�]������
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RotateAndAnimate(rotationAngle); // �E�L�[�������ꂽ�Ƃ��A�v���C���[���E�ɉ�]������
        }

        // wasd�L�[�������ꂽ�u�Ԃɕ��s�A�j���[�V�������~����
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("walk", false); // ���s�A�j���[�V�������~
        }
    }

    // �v���C���[�̉�]�ƕ��s�A�j���[�V�����̐���
    void RotateAndAnimate(float angle)
    {
        transform.rotation = Quaternion.Euler(0f, angle, 0f); // �v���C���[���w�肳�ꂽ�p�x�ɉ�]������
        animator.SetBool("walk", true); // ���s�A�j���[�V�������J�n
    }
}