using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

/// <summary>銃のスクリプト</summary>
public class Launcher : MonoBehaviour
{
    [SerializeField, Header("弾のプレハブ")] Bullet _bulletPrefab;

    [SerializeField, Header("1回の弾の最大数")] int _maxBullet;

    IObjectPool<Bullet> _bulletPool;
    void Awake()
    {
        _bulletPool = new ObjectPool<Bullet>(CreateBullet, OnGetBullet
                                                                , OnReleaseBullet, OnDestroyBullet
                                                                , maxSize: _maxBullet
                                                             );
    }

    Bullet CreateBullet ()
    {
        Bullet bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);

        bullet.SetPool(_bulletPool);

        return bullet;
    }

    void OnGetBullet(Bullet bulletObj)
    {
        bulletObj.gameObject.SetActive(true);

        bulletObj.transform.position = transform.position;
    }

    void OnReleaseBullet(Bullet bulletObj)
    {
        bulletObj.gameObject.SetActive(false);
    }

    void OnDestroyBullet(Bullet bulletObj)
    {
        Destroy(bulletObj.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _bulletPool?.Get();
        }
    }
}
