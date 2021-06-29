using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Vector3 rotateAxis;
    private Transform wheellTrans;
    void Start()
    {
        wheellTrans = transform.GetChild(0).GetChild(0);
    }

    
    void Update()
    {
        wheellTrans.transform.Rotate(rotateAxis * rotateSpeed * Time.deltaTime);
    }
}
