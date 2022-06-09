using UnityEngine;

/// <summary>
/// Playerのアニメーターを管理するスクリプト
/// </summary>
public class PlayerAnimator : MonoBehaviour
{
    /// <summary> Playerのアニメーターのメンバ変数</summary>
    Animator m_animator => GetComponent<Animator>();

    /// <summary> Playerのアニメーター(外部呼び出し用)のメンバ変数</summary>
    public Animator Animotion => m_animator; 


    /// <summary>
    /// Playerのアニメーターのモーション判定のメソッド
    /// </summary>
    /// <param name="h_move"></param>
    /// <param name="v_move"></param>
    public void JudgeAnimotion (float h_move , float v_move)
    {
        m_animator.SetFloat("Direction_X",h_move);

        m_animator.SetFloat("Direction_Y",v_move);
    }
}
