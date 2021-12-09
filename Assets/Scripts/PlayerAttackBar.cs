using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBar : MonoBehaviour
{
    private Animator _ani;
    private Animator _aniSlash;
    private Animator _aniSans;

    [SerializeField] private GameObject _AttackBar;
    [SerializeField] private GameObject _slash;
    [SerializeField] private GameObject _Sans;

    [SerializeField] private int _speed;
    [SerializeField] private float _MaxDistanceX;

    private bool _stop = false;

    private void Start()
    {
        _ani = _AttackBar.GetComponent<Animator>();
        _aniSlash = _slash.GetComponent<Animator>();
        _aniSans = _Sans.GetComponent<Animator>();
        
    }

    private void Update()
    {
        //When Enter is pressed you 'Attack();'  
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Attack();
        }

        //Moves the bar till Enter is pressed
        if(_AttackBar.transform.position.x < _MaxDistanceX && _stop == false)
        {
            _AttackBar.transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
        }

    }

    public void Attack()
    {
        //Stops the bar form moving
        _stop = true;
        _ani.Play("Base Layer.white bar flicker",0);

        _slash.SetActive(true);
        _aniSlash.Play("Base Layer.slash_animation", 0);
        _aniSans.Play("Base Layer.SansMovingAway", 0);

        //play's bar animation
        //play's slash animation
        //Moves sans
    }
}
