using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerの移動に関するスクリプト
/// </summary>

public class PlayerMortion 
{
    
    public float PlayerSpeed;
    Rigidbody2D m_playerRigid2D;

    PlayerAnimator playerAnimator;

    

    public void Move(float h_move,float v_move)
    {
        Vector2 direction = new Vector2(h_move, v_move).normalized;

        m_playerRigid2D.velocity = direction * PlayerSpeed;

        playerAnimator.JudgeAnimotion(h_move, v_move);
    }
}