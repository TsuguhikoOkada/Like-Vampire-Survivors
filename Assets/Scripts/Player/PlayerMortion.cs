using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Playerの移動に関するスクリプト</summary>
public class PlayerMortion 
{
    Rigidbody2D m_playerRigid2D;

    PlayerAnimator playerAnimator;

    PlayerData playerData;

    public void Move(float h_move,float v_move)
    {
        Vector2 direction = new Vector2(h_move, v_move).normalized;

        m_playerRigid2D.velocity = direction * playerData.PlayerSpeed;

        playerAnimator.JudgeAnimotion(h_move, v_move);
    }
}