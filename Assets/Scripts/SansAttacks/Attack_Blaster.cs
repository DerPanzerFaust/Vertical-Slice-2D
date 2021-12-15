using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Blaster : MonoBehaviour
{
    private Animation anim;
    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
    public void PlayAnimation()
    {
        anim.Play();
    }
}
