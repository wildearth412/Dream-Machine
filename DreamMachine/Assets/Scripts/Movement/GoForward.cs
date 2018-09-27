using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForward : MonoBehaviour
{
    public Vector3 boranAreaCenter;
    public float bornAreaWidth = 10.0f;
    public float bornAreaHeight = 3.0f;
    public float speed = 5.0f;
    public float vanishPoint = -65.0f;

    void Start () {
		
	}

    void Update ()
    {
        Vector3 v = this.transform.localPosition;
        Vector3 vf = new Vector3(0,0,-speed * Time.deltaTime);
        this.transform.localPosition = v + vf;

        if(this.transform.localPosition.z < vanishPoint)
        {
            v = new Vector3(Random.Range(-bornAreaWidth, bornAreaWidth),0,Random.Range(-bornAreaHeight, bornAreaHeight));
            this.transform.localPosition = v + boranAreaCenter;
        }		
	}
}
