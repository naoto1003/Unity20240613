using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    //�Փˎ��ɌĂ΂��
    private void OnCollisionEnter(Collision collision)
    {
        //���������Q�[���I�u�W�F�N�g���폜����
        Destroy(collision.gameObject);
    }
}
