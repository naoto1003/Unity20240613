using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    //�����ƂԂ��������ɌĂ΂��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        //�Q�[���I�u�W�F�N�g���폜���郁�\�b�h
        Destroy(gameObject);
    }
}
