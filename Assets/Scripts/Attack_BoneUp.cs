using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_BoneUp : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    private Vector3 _origin;
    [SerializeField]
    private float _maxHeigth;

    //If statement separaters
    bool First = true;
    bool Next = false;

    //Timer stuff
    [SerializeField]
    private float fireRate = 0.5f;
    private float NextFire = 0.0f;

    private void Awake()
    {
        _origin = transform.position;
        NextFire = Time.time + fireRate;
    }
    private void Update()
    {
        //Going up to _maxHeight
        if (transform.position.y < _maxHeigth && First == true)
        {
            transform.position += new Vector3(0, _speed, 0) * Time.deltaTime;
            //if _maxHeight is reached, going up will stop
            if (transform.position.y >= _maxHeigth)
            {
                First = false;
            }
        }

        //Time Waiting to go down
        if (Time.time > NextFire && First == false)
        {
            NextFire = Time.time + fireRate;
            Next = true;
        }

        //Going down to _origin
        if (transform.position.y > _origin.y && Next == true)
        {
            transform.position += new Vector3(0, -_speed, 0) * Time.deltaTime;
        }
    }
}
