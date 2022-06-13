using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Player関連のものをまとめたスクリプト</summary>

public class Player : MonoBehaviour
{
    PlayerData playerData;

    PlayerAnimator playerAnimator = new PlayerAnimator() ;

    [SerializeField]PlayerMortion playerMortion = new PlayerMortion() ;

    [SerializeField,Header("キャラ")] CharacterEnum character;

    float _hInput;

    float _vInput;


    void Start()
    {
        
        playerAnimator.Animotion = GetComponent<Animator>();
        playerMortion.PlayerRigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _hInput = Input.GetAxis("Horizontal");

        _vInput = Input.GetAxis("Vertical");
        
       playerMortion.PlayerOperation(_hInput,_vInput);
    }

    void FixedUpdate()
    {
        playerMortion.Move(_hInput,_vInput);

       playerAnimator.JudgeAnimotion(_hInput, _vInput);

    }
}