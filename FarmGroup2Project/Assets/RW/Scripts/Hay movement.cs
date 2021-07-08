using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haymovement : MonoBehaviour
{
    public float speed = 4f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
