using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour
{


    public BoxCollider colliding;
    public bool doubble;
    //public BoxCollider extraspeed;

    // Start is called before the first frame update
    void Start()
    {
       
       colliding.enabled = !colliding.enabled;
      /*  extraspeed = GetComponent<BoxCollider>();
        extraspeed.enabled = !extraspeed.enabled;*/

    }








    IEnumerator timing()
    {

        yield return new WaitForSeconds(2);
        // colliding.SetActive(true);
        colliding.enabled = !colliding.enabled;
       // extraspeed.enabled = !extraspeed.enabled;
        StartCoroutine(stop());


    }
   
    IEnumerator stop()

    {
        Debug.Log("stop");
        yield return new WaitForSeconds(3);
        colliding.enabled = !colliding.enabled;
        //extraspeed.enabled = !extraspeed.enabled;
        Debug.Log("stopped");

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(timing());
       



       
    }
}
