using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.25f;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 velocity = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetposition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetposition, ref velocity, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
