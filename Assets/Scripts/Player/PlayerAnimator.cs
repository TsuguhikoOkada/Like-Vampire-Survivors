using UnityEngine;

/// <summary>
/// Playerのアニメーターを管理するスクリプト
/// </summary>
public class PlayerAnimator
{
    /// <summary> Playerのアニメーターのメンバ変数</summary>
    Animator m_animator;

    /// <summary> Playerのアニメーター(外部呼び出し用)のメンバ変数</summary>
    public Animator Animotion { get => m_animator; set => m_animator = value; }


    /// <summary>
    /// Playerのアニメーターのモーション判定のメソッド
    /// </summary>
    /// <param name="h_animator_move"></param>
    /// <param name="">v_animator_move</param>
    public void JudgeAnimotion (float h_animator_move , float v_animator_move)
    {
        m_animator.SetFloat("Direction_X",h_animator_move);

        m_animator.SetFloat("Direction_Y",v_animator_move);
    }
}
