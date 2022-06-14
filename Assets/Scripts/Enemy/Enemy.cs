using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Enemy : MonoBehaviour
{
    [SerializeField,Header("キャラ")] CharacterEnum enemyCharacter;

    TargetEnum target = TargetEnum.Player;

    [SerializeField,Header("敵のデータ")] EnemyData enemyData;

    EnemyMortion enemyMortion = new EnemyMortion();

    GameObject _targetObj;

    GameObject _enemyObj;

    float _xMove;

    float _yMove;

    void OnEnable()
    {
        _targetObj = GameObject.FindGameObjectWithTag(target.ToString());

        _enemyObj = GameObject.FindGameObjectWithTag(enemyCharacter.ToString());
    }

    void Start()
    {
        enemyMortion.EnemyRigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        enemyMortion.PlayerChase(_targetObj,_enemyObj, _xMove, _yMove);
    }
}