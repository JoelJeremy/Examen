using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public Health _Health;
    TMP_Text _Text;

    // Start is called before the first frame update
    void Start()
    {
        _Text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = _Health._CurrentHealth.ToString();
    }
}
