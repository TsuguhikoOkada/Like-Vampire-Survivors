using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Player関連のものをまとめたスクリプト</summary>

public class Player : MonoBehaviour
{
    [SerializeField,Header("プレイヤーデータ")] PlayerData playerData;

    [SerializeField] PlayerAnimator playerAnimator;

    [SerializeField] PlayerMortion playerMortion;

    float _hInput;

    float _vInput;
    
    

    
    void Update()
    {
        playerMortion.PlayerOperation(_hInput,_vInput);
    }

    void FixedUpdate()
    {
        playerMortion.Move();

        _hInput = Input.GetAxis("Horizontal");

        _vInput = Input.GetAxis("Vertical");

        playerAnimator.JudgeAnimotion(_hInput, _vInput);
    }
}
