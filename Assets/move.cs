using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    float a;
    float b = 5;
    Fancy f;

    // Update is called once per frame
    void Update () {
        transform.Rotate (new Vector2 (3f, 4f));
        a = 3;
        fancy ();
        f = new Fancy ();
    }

    void Going () {
        fancy ();
        fancy ();
    }

    void fancy () {
        a = 5 + b;
    }
}