using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBG : MonoBehaviour
{
    public GameObject rotationTarget;
    public GameObject leftObj;
    public GameObject rightObj;
    public float rotateSpeed = 1.0f;
    private Quaternion lastRotation;

    void Start ()
    {
        lastRotation = rotationTarget.transform.rotation;
    }
	
	void Update ()
    {
		if(Input.GetKey(KeyCode.LeftArrow))
        {
            float step = rotateSpeed * Time.deltaTime;
            Quaternion rot = Quaternion.RotateTowards(lastRotation, rightObj.transform.rotation, step);
            rotationTarget.transform.rotation = rot;
            lastRotation = this.transform.rotation;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            float step = rotateSpeed * Time.deltaTime;
            Quaternion rot = Quaternion.RotateTowards(lastRotation, leftObj.transform.rotation, step);
            rotationTarget.transform.rotation = rot;
            lastRotation = this.transform.rotation;
        }
	}
}
