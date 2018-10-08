using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Controller : MonoBehaviour {


 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.left);

        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.forward);

        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.back);

        }
        
    }
}
