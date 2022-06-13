using System;
using UnityEngine;

/// <summary>Enemyの動作に関するスクリプト</summary>
[Serializable]
public class EnemyMortion
{
    Rigidbody2D m_enemyRigid2D;

    public Rigidbody2D EnemyRigid2D { get => m_enemyRigid2D; set => m_enemyRigid2D = value; }

    [SerializeField]Transform m_target_Transform;
    public void PlayerChase(TargetEnum targetChase,float enemy_h_move,float enemy_v_move)
    {
        //targetChase = TargetEnum.Player;

        Vector2 enemyDirection = new Vector2(enemy_h_move,enemy_v_move).normalized;

        //Vector2 dir = targetChase.transform

        m_enemyRigid2D.velocity = enemyDirection;
    }
}