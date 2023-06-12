using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        print("blabla");
    }

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}