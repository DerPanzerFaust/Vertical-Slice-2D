using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceAttack : MonoBehaviour
{

    private PushDownAttack _pushDownAttack;
    private SetActive _setActive;

    [SerializeField] private GameObject WaveInit;
    [SerializeField] private GameObject UpInit;
    [SerializeField] private GameObject BlasterInit;

    [Header("SansAnimations")]
    [SerializeField] private GameObject _Sans;
    [SerializeField] private GameObject _SansIdle;
    private Animator _ani;
    private Animator _aniIdle;

    private bool _Start = false;


    private void Start()
    {
        
        _pushDownAttack = FindObjectOfType<PushDownAttack>();
        _setActive = FindObjectOfType<SetActive>();
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

            _pushDownAttack._Attack = true;     //PushDown
            WaitAndAttack();                    //BoneUp 1
        }
    }

    public void WaitAndAttack()
    {
        StartCoroutine(_wait());
    }

    IEnumerator _wait()
    {
        _Sans.SetActive(true);
        _SansIdle.SetActive(false);
        _ani = FindObjectOfType<Animator>();

        //Bones
        _ani.Play("Base Layer.Slam down", 0);
        yield return new WaitForSeconds(.5f);
        _ani.Play("Base Layer.Hand up", 0);
        UpInit.GetComponent<AttackInitiator>().WhatAttack = 1;      //BoneUp 1
        yield return new WaitForSeconds(.7f);
        _ani.Play("Base Layer.hand left", 0);
        WaveInit.GetComponent<AttackInitiator>().WhatAttack = 2;    //BoneWave 2

        //Blasters
        yield return new WaitForSeconds(2f);
        _ani.Play("Base Layer.Eye's dark", 0);
        BlasterInit.GetComponent<AttackInitiator>().WhatAttack = 3; //BlasterSides 3
        yield return new WaitForSeconds(2f);
        BlasterInit.GetComponent<AttackInitiator>().WhatAttack = 4; //BlasterCorners 4
        yield return new WaitForSeconds(2f);
        BlasterInit.GetComponent<AttackInitiator>().WhatAttack = 3; //BlasterSides 3
        yield return new WaitForSeconds(2f);
        BlasterInit.GetComponent<AttackInitiator>().WhatAttack = 5; //BlasterDubble 5

        //Rescale   Sans_idle_animation
        yield return new WaitForSeconds(5f);

        _setActive.ActivateRescale();

        _SansIdle.SetActive(true);
        _aniIdle = _SansIdle.GetComponent<Animator>();

        _Sans.SetActive(false);


    }
}
