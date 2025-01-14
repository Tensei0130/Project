using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public enum EnemyState
    {
        Walk,
        Wait,
        Chase,
        Attack,
        Freeze
    }
    [SerializeField]
    private float freezeTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        if(state == EnemyState.Walk)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
