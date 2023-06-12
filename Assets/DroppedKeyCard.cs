using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedKeyCard : DroppedItem
{
    public int _CodeIndex;

    public override void PickUp()
    {
        KeyCardManager.KCM.AddKeyindex(_CodeIndex);
        base.PickUp();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void SetCode(int CodeIndex)
    {
        _CodeIndex = CodeIndex;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}