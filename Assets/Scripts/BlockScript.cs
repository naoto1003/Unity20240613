using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    //何かとぶつかった時に呼ばれるビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //ゲームオブジェクトを削除するメソッド
        Destroy(gameObject);
    }
}
