using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceAttack : MonoBehaviour
{

    private AttackInitiator _attackInitiator;
    private PushDownAttack _pushDownAttack;

    private bool _Start = false;


    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Start = true;
        }

        if(_Start == true)
        {
            _Start = false;
            //push
            _pushDownAttack._Attack = true; //PushDown
            //Bones
            WaitAndAttack(1f); //BoneUp 1
            //WaitAndAttack(1f); //BoneWave 2
            //Blasters
            //WaitAndAttack(1f); //BlasterSides 3
            //WaitAndAttack(1f); //BlasterCorners 4
            //WaitAndAttack(1f); //BlasterSides 3
            //WaitAndAttack(1f); //BlasterDubble 5

        }
    }

    public void WaitAndAttack(float time)
    {
        StartCoroutine(_wait(time));

    }

    IEnumerator _wait(float time)
    {
        //Bones
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 1;
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 2;

        //Blasters
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 3;
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 4;
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 3;
        yield return new WaitForSeconds(time);
        _attackInitiator.WhatAttack = 5;

    }

    public void Setup()
    {
        _attackInitiator = FindObjectOfType<AttackInitiator>();
        _pushDownAttack = FindObjectOfType<PushDownAttack>();
    }
}
