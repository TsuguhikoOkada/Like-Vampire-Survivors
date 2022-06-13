using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

/// <summary>弾のスクリプト</summary>

public class Bullet : MonoBehaviour
{
    /// <summary>弾の速度を表すメンバ変数</summary>
    [SerializeField, Header("弾速度")] Vector2 _bulletVelocity;

    /// <summary>弾のRigidBody2Dのメンバ変数</summary>
    Rigidbody2D _rb2DB => GetComponent<Rigidbody2D>();

    IObjectPool<Bullet> _pool;

    public void SetPool(IObjectPool<Bullet> pool)
    {
        _pool = pool;
    }

    /// <summary>
    /// 弾の速度計算をFixed Updateで実行
    /// </summary>
    void FixedUpdate()
    {
        _rb2DB.velocity = _bulletVelocity;
    }

    /// <summary>
    /// カメラに見えなくなったら自身を消す
    /// </summary>
    void OnBecameInvisible()
    {
        _pool?.Release(element:this);
    }
}