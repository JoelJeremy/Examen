using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractManager : MonoBehaviour
{
    public float _Range;
    public TMP_Text _TextPrompt;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit _Hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out _Hit, _Range))
        {
            if (_Hit.collider.gameObject.GetComponent<Interactable>())
            {
                print("Looking at interactable");
                _TextPrompt.enabled = true;
                _TextPrompt.text = "Press E to interact with " + _Hit.collider.gameObject.GetComponent<Interactable>().GetType().ToString();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    _Hit.collider.gameObject.GetComponent<Interactable>().Interact();
                }
            }
        }
        else
        {
            _TextPrompt.enabled = false;
        }
    }
}