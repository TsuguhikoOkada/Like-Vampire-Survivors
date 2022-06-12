using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Player関連のものをまとめたスクリプト</summary>

public class Player : MonoBehaviour
{
    PlayerData playerData;

    PlayerAnimator playerAnimator = new PlayerAnimator() ;

    [SerializeField]PlayerMortion playerMortion = new PlayerMortion() ;

    float _hInput;

    float _vInput;


    void Start()
    {
        
        playerAnimator.Animotion = gameObject.GetComponent<Animator>();
        playerMortion.PlayerRigid2D = gameObject.GetComponent<Rigidbody2D>();
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

        //playerAnimator.Animotion.SetFloat("Direction_X", _hInput);

        //playerAnimator.Animotion.SetFloat("Direction_Y", _vInput);
    }
}