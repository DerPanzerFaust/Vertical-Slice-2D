using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDownAttack : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private movement2 _movement2;
    private Rigidbody2D rb;

    public bool _movementUpdate { get;  set; }

    [SerializeField]
    private float _pushPower;
    private bool _pushDown = false;

    public bool _Attack = false;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _movement2 = FindObjectOfType<movement2>();
    }

    private void Update()
    {
        //When NumbPad 7 is presed 'PushDown();' will be activated 
        if (Input.GetKeyDown(KeyCode.Keypad7) || _Attack == true)
        {
            _Attack = false;
            _pushDown = true;
        }


        if (_pushDown)
        {
            PushDown();
        }
    }

    public void PushDown()
    {
        if (_movement2.isGrounded == false)
        {
            _movement2.redmode = true;

            //Sets the force of the downwards push with '_pushPower'
            rb.gravityScale = _pushPower;

            _movementUpdate = true;
        }

        //When grounded, the push wil be deactivated
        if (_movement2.isGrounded)
        {

            _movement2.redmode = false;
            _movementUpdate = true;

            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 0;


            //Disables the function
            _pushDown = false;

        }
        //_movementUpdate = false;
    }
}
