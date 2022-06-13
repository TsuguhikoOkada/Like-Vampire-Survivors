using System;
using UnityEngine;

/// <summary>敵のデータ(ステータス等)を管理するスクリプト</summary>

[Serializable]
public struct EnemyData
{
    #region Serialize Private Fields

    [SerializeField, Header("敵のレベル")] int _enemyLevel;

    [SerializeField, Header("敵のHP")] int _enemyHp;

    [SerializeField, Header("敵の防御力")] int _enemyDEF;

    #endregion

    #region Public Propeties

    public int EnemyLevel { get => _enemyLevel;set => _enemyLevel = value; }

    public int EnemyHp { get => _enemyHp; set => _enemyHp = value; }

    public int EnemyDEF { get => _enemyDEF; set => _enemyDEF = value; }

    #endregion
}
