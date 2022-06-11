using System;
using UnityEngine;

/// <summary>Playerのデータを管理するスクリプト</summary>
[Serializable]
public struct PlayerData
{
    #region private

    #region 変化する値

    [SerializeField, Header("Playerレベル")] int _playerLevel;

    [SerializeField,Header("PlayerのHP")]int _playerHp;

    [SerializeField,Header("PlayerのMP")]int _playerMp;

    [SerializeField, Header("Playerの攻撃力")] int _playerATK;

    [SerializeField, Header("Playerの防御力")] int _playerDEF;

    #endregion

    #region 固定値

    [SerializeField, Header("Playerのスピード")] float _playerSpeed;

    #endregion

    #endregion

    #region public

    #region ゲッターセッター

    public int PlayerLevel { get => _playerLevel; set => _playerLevel = value; }

    public int PlayerHp { get => _playerHp; set => _playerHp = value; }

    public int PlayerMp { get => _playerMp; set => _playerMp = value; }

    public int PlayerATK { get => _playerATK; set => _playerATK = value; }

    public int PlayerDEF { get => _playerDEF; set => _playerDEF = value; }

    public float PlayerSpeed { get => _playerSpeed; set => _playerSpeed = value; }

    #endregion

    #endregion
}
