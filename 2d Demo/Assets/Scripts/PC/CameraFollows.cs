using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour {

    public Transform target;
    public float smoothing = 5f;

    Vector3 offset;

    void Start() {
        offset = this.transform.position - target.position;
    }

    void FixedUpdate() {
        Vector3 targetCamPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPosition, smoothing * Time.deltaTime);
    }
}
