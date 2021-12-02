using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescale : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    public float speed = 0.1f;
    public Vector3 newScale;

    private void Update()
    {
        if (transform.localScale.x <= newScale.x)
        {
            //transform.localScale += new Vector3(1.310799f * Time.deltaTime, 0, 0);
            //transform.localScale += new Vector3(1.266701f * Time.deltaTime, 0, 0);
            transform.localScale += new Vector3(1.311456f * Time.deltaTime, 0, 0);
        }
    }  
}
