using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_BoneWave : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    private void Update()
    {
        MoveAttack();
    }

    public void MoveAttack()
    {
        transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
    }
}
