using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float startspeed;
    [SerializeField] private float plusSpeed;

    [SerializeField] private float currentSpeed;

    void Start()
    {
        currentSpeed = startspeed;
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * currentSpeed * Time.fixedDeltaTime);
        StartCoroutine(plusmovespeed());

    }
    IEnumerator plusmovespeed()
    {
        yield return new WaitForSeconds(1);
        currentSpeed += plusSpeed;
    }
    
    
}