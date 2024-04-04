using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    [SerializeField] float _speedofAutorotation = 10f;


    // Update is called once per frame
    void Update()
    {
     transform.Rotate(Vector3.up * _speedofAutorotation * Time.deltaTime); 
    }
}
