using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Enemyの動作に関するスクリプト</summary>
public class EnemyMortion
{
    Rigidbody2D m_enemyRigid2D;

    public Rigidbody2D EnemyRigid2D { get => m_enemyRigid2D; set => m_enemyRigid2D = value; }


    public void EnemyMove(float enemy_h_move,float enemy_v_move)
    {
        Vector2 enemyDirection = new Vector2(enemy_h_move,enemy_v_move).normalized;

        m_enemyRigid2D.velocity = enemyDirection;
    }
}
