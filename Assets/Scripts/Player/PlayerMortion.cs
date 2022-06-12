using System;
using UnityEngine;

/// <summary>Playerの移動に関するスクリプト</summary>

[Serializable]
public class PlayerMortion 
{
    PlayerAnimator playerAnimator;

   [SerializeField] PlayerData playerData;


    Rigidbody2D m_playerRigid2D;

    public Rigidbody2D PlayerRigid2D { get => m_playerRigid2D; set => m_playerRigid2D = value; }

    float _hInput;
    float _vInput;

    public void PlayerOperation(float h_move, float v_move)
    {
        h_move = Input.GetAxis("Horizontal");

        v_move = Input.GetAxis("Vertical");

        _hInput = h_move;

        _vInput = v_move;
    }

    public void Move(float h_move,float v_move)
    {
        Vector2 direction = new Vector2(h_move , v_move ).normalized;

        m_playerRigid2D.velocity = direction * playerData.PlayerSpeed;

        //playerAnimator.Animotion.SetFloat("Direction_X", h_move);

        //playerAnimator.Animotion.SetFloat("Direction_Y",v_move);
        //h_move = Input.GetAxis("Horizontal");
        //v_move = Input.GetAxis("Vertical");
        //playerAnimator.JudgeAnimotion( h_move, v_move);
    }
}