using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//[DefaultExecutionOrder(1)]
[RequireComponent(typeof(RotationConstraint))]
public class GearRotation : MonoBehaviour
{
    public bool isActive;
    public float weight = 1.0f;
    public bool x;
    public bool y;
    public bool z;
    public int axisLinkIdx = 4;       // 0 - x2x, 1 - y2x, 2 - z2x, 3 - x2y, 4 - y2y, 5 - z2y, 6 - x2z, 7 - y2z, 8 - z2z
    private RotationConstraint rc;
    [SerializeField]
    private Vector3 currentOffset;

    private void Start()
    {
        this.rc = GetComponent<RotationConstraint>();
        this.rc.weight = weight;
    }

    private void Update ()
    {
        if(isActive)
        {
            Quaternion rotation = this.rc.GetSource(0).sourceTransform.rotation;
            currentOffset = new Vector3(rotation.eulerAngles.x * (x ? -2.0f : 1.0f), rotation.eulerAngles.y * (y ? -2.0f : 1.0f), rotation.eulerAngles.z * (z ? -2.0f : 1.0f));
            this.rc.rotationOffset = currentOffset;
        }
    }

    public void SetWeight(float w)
    {
        this.rc.weight = w;
    }
}
