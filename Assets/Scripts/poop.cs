using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poop : MonoBehaviour
{

    public BoxCollider colliding;
    // Start is called before the first frame update
    void Start()
    {
        colliding = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            colliding.enabled = !colliding.enabled;
        }
    }
}
