using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

/// <summary>タイトルやリザルト画面での遷移動作スクリプト</summary>

public class SceneChangeBehavior : MonoBehaviour
{
    /// <summary>WaitforSecondsでの待機時間のメンバ変数</summary>
    [SerializeField, Header("シーン切り換え待機時間")] float _second;

    /// <summary>移動させるシーン名を設定するメンバ変数</summary>
    [SerializeField, Header("遷移シーン名")] string _sceneName;

    /// <summary>WaitforSecondsのメンバ変数</summary>
    WaitForSeconds _wfs => new WaitForSeconds(_second);

    /// <summary>シーン遷移させるボタンのboolメンバ変数</summary>
    bool _actionInput => Input.anyKeyDown;

    /// <summary>
    /// OnKeyDownActionメソッドを呼び出す
    /// </summary>
    void Update()
    {
        OnKeyDownAction();
    }

    /// <summary>
    /// 何かキーを押した時にLoadSceneメソッドを呼び出す
    /// </summary>
    void OnKeyDownAction()
    {
        if (_actionInput)
        {
            LoadScene();
        }
    }

    /// <summary>
    /// シーン遷移する前にコルーチンでStandByTimeメソッドを呼び出す
    /// </summary>
    void LoadScene()
    {
        StartCoroutine(StandByTime());
    }

    /// <summary>
    /// 数秒待機してからシーンを遷移する
    /// </summary>
    /// <returns></returns>
    IEnumerator StandByTime()
    {
        yield return _wfs;

        SceneManager.LoadScene(_sceneName);

    }
}
