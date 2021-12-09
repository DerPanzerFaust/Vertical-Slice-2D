using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationess : MonoBehaviour
{

    public Transform a;

    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        a = a.GetComponent<Transform>();
        Debug.Log(a.position);
        anim = gameObject.GetComponent<Animation>();
        anim["tets"].layer = 123;

    }

    // Update is called once per frame
    void Update()
    {
        if (anim.isPlaying)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Spinning");
            anim.Play("tets");
        }


    }
}
