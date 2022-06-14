using System;
using UnityEngine;

/// <summary>Enemyの動作に関するスクリプト</summary>
public class EnemyMortion
{
    Rigidbody2D m_enemyRigid2D;

    public Rigidbody2D EnemyRigid2D { get => m_enemyRigid2D; set => m_enemyRigid2D = value; }

    float enemySpeed = 1f;
    public void PlayerChase(GameObject targetObj,GameObject enemyObj,float enemy_h_move,float enemy_v_move)
    {

        Vector2 targetDirection = (targetObj.transform.position - enemyObj.transform.position).normalized;

        enemy_h_move = targetDirection.x * enemySpeed;

        enemy_v_move = targetDirection.y * enemySpeed;

        m_enemyRigid2D.velocity = new Vector2(enemy_h_move,enemy_v_move);

       // enemyObj.GetComponent<SpriteRenderer>().flipX = (enemy_h_move < 0);
    }
}