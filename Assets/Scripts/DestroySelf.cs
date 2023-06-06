using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    public float time;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}