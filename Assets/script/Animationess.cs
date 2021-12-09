using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationess : MonoBehaviour
{

    // public Transform Playerpos;
    public GameObject player;
    public Animator anim;
    private bool animdonecheck = false;
    private void FixedUpdate()
    {
        // Debug.Log(Playerpos.position);
        Debug.Log(player.transform.position);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            player.GetComponent<Animator>().Play("testing");
            animdonecheck = true;
        }
       /* if ( anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {  
            if(animdonecheck == true)
            {
                //If normalizedTime is 0 to 1 means animation is playing, if greater than 1 means finished
                Debug.Log("not playing");
                player.GetComponent<Animator>().Play("testing2");

            }
        }*/

    }
}
