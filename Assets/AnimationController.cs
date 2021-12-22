using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj.GetComponent<Animation>().Play("birds are singing animation00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
