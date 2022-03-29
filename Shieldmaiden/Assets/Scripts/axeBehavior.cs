using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axeBehavior : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject hand = GameObject.FindWithTag("mano");
        transform.parent = hand.transform;
       // this.gameObject.transform.position = hand.transform.position;
    }


}
