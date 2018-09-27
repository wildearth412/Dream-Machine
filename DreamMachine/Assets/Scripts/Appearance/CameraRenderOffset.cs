using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRenderOffset : MonoBehaviour
{
    public Vector3 offset = new Vector3(0,1.0f,0);
    private Camera cam;

	void Start ()
    {
        cam = GetComponent<Camera>();
	}
	void LateUpdate ()
    {
        Vector3 camOffset = new Vector3(-offset.x,-offset.y,offset.z);
        Matrix4x4 m = Matrix4x4.TRS(camOffset,Quaternion.identity,new Vector3(1,1,-1));
        cam.worldToCameraMatrix = m * transform.worldToLocalMatrix;
	}
}
