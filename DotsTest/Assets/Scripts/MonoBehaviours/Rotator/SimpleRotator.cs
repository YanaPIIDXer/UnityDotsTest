using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MonoBehaviourだけで回転を実装
/// </summary>
public class SimpleRotator : MonoBehaviour
{
    /// <summary>
    /// １秒間の回転量
    /// </summary>
    private static readonly Vector3 RotateValueBySec = new Vector3(0.0f, -RotatorConfig.RotateSpeed, 0.0f);
    
    protected void Update()
    {
        transform.localEulerAngles += RotateValueBySec * Time.deltaTime;
    }
}
