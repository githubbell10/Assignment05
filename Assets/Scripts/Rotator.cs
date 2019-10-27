using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        float m = keepData.TargetRotationSpeedMultiplier;
        transform.Rotate(new Vector3(m*15,m*30,m*45) * Time.deltaTime);   

    }
}
