using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    
    public Transform target;
    public float smoothSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 startPosition = new Vector3(target.position.x, target.position.y + 1f, -35f);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, startPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
