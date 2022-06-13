using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Enemy : MonoBehaviour
{
    [SerializeField,Header("キャラ")] CharacterEnum enemyCharacter;

    

    [SerializeField,Header("敵のデータ")] EnemyData enemyData;

    EnemyMortion enemyMortion = new EnemyMortion();

    
    void Start()
    {
        //targetCharacterType = CharacterEnum.Player;
        enemyMortion.EnemyRigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }
}