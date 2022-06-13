using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>Timerを管理するスクリプト</summary>

public class Timer : MonoBehaviour
{
    [SerializeField, Header("タイマーテキスト")] TextMeshProUGUI _timerText;

    float _time;


    void Update()
    {
        TimeCountUpStart();
    }


    void TimeCountUpStart()
    {
        // 毎フレームカウントアップ
        _time += Time.deltaTime;

        // 分 timeを60で割った値を代入
        int minute = (int)_time / 60;

        // 秒 timeを60で割った余りの値を代入
        int second = (int)_time % 60;

        string minuteText;

        string secondText;


        // 10未満(分の表示が1桁)なら
        if (minute < 10)
        {
            // 0埋めしてintをstringに変換
            minuteText = "0" + minute.ToString();
        }
        else
        {
            // それ以外ならそのままstringに変換
            minuteText = minute.ToString();
        }

        // 10未満(秒の表示が1桁)なら
        if (second < 10)
        {
            // 分の時と一緒
            secondText = "0" + second.ToString();
        }
        else
        {
            // それ以外の時も一緒
            secondText = second.ToString();
        }

        _timerText.text = "Time" + minuteText + ":" + secondText;
    }
}
