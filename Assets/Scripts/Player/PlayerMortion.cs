using System;
using UnityEngine;

/// <summary>Playerの移動に関するスクリプト</summary>

[Serializable]
public class PlayerMortion 
{
    PlayerAnimator playerAnimator;

    PlayerData playerData;


    [SerializeField]Rigidbody2D m_playerRigid2D;

    public Rigidbody2D PlayerRigid2D { get => m_playerRigid2D; set => m_playerRigid2D = value; }

    public float Speed { get; set; }

    float _hInput;

    float _vInput;
    
    public void PlayerOperation(float h_move,float v_move)
    {
        h_move = Input.GetAxis("Horizontal");
        v_move = Input.GetAxis("Vertical");

        _hInput = h_move;
        _vInput = v_move;
    }

    public void Move()
    {
        Vector2 direction = new Vector2(_hInput * playerData.PlayerSpeed, _vInput * playerData.PlayerSpeed).normalized;

        m_playerRigid2D.velocity = direction ;

        //playerAnimator.JudgeAnimotion( _hInput, _vInput);
    }
}