using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerのアニメーションを管理するスクリプト
/// </summary>
public class PlayerAnimeBase : MonoBehaviour
{
    /// <summary> Playerのアニメーターのメンバ変数</summary>
    Animator m_animator => GetComponent<Animator>();

    /// <summary> Playerのアニメーター(外部呼び出し用)のメンバ変数</summary>
    public Animator Animotion =>m_animator;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
