using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class AdjustOffset : MonoBehaviour
{
    private MeshRenderer render;
    private Vector2 v;
    public float speed = -1.0f;

	void Start ()
    {
        render = this.transform.GetComponent<MeshRenderer>();
	}
	
	void Update ()
    {
        v = new Vector2(0,Time.time * speed);
        render.sharedMaterial.SetTextureOffset("_MainTex",v);
	}
}
