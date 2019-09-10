using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    float a;
    [SerializeField] float speed;
    Vector3 pos;
    float x;
    [SerializeField] float direc;
    [SerializeField] float xinc;

    private void Start () {
        x = 0f;
        direc = -direc;
    }

    // Update is called once per frame
    void Update () {
        horizontalOscillation ();
    }

    void horizontalOscillation () {
        // Probably better to control the position without the speed
        //transform.position += new Vector3 (speed, 0f, 0f);
        x += direc * xinc;

        if (x > 5f || x < -5f) {
            direc = -direc;
        }
        pos.x = x;
        transform.position = new Vector3 (x, 0f, 0f);

    }

}