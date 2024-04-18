using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 20 * Time.deltaTime, 0f, Space.Self);
    }
}
