using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    //衝突時に呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        //当たったゲームオブジェクトを削除する
        Destroy(collision.gameObject);
    }
}
