using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class AimController : MonoBehaviour
{

    public float multiplier;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+ new Vector3(Input.GetAxis("Mouse X")* multiplier, Input.GetAxis("Mouse Y")* multiplier, 2);
        if (Vector3.Distance(transform.position, new Vector3(20,20,2)) <1)
        {
            transform.position = new Vector3(0, 0, 2);
        }
    }
}
