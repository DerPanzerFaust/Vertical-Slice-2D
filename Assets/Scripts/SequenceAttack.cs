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
            WaitAndAttack(1f, 1); //BoneUp
            WaitAndAttack(1f, 2); //BoneWave
            //Blasters
            WaitAndAttack(1f, 3); //BlasterSides
            WaitAndAttack(1f, 4); //BlasterCorners
            WaitAndAttack(1f, 3); //BlasterSides
            WaitAndAttack(1f, 5); //BlasterDubble

        }
    }

    public void WaitAndAttack(float time, int attack)
    {
        StartCoroutine(_wait(time, attack));

    }

    IEnumerator _wait(float time, int attack)
    {
        //Sets the attack
        _attackInitiator.WhatAttack = attack;
        Debug.Log("HIER KOM IK");

        yield return new WaitForSeconds(time);

    }



    public void Setup()
    {
        _attackInitiator = FindObjectOfType<AttackInitiator>();
        _pushDownAttack = FindObjectOfType<PushDownAttack>();
    }
}
