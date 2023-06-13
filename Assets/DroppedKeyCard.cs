using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedKeyCard : DroppedItem
{
    public int _CodeIndex;

    public override void PickUp()
    {
        //this generates the  4 digid code when the a enemy drops the keycard
        KeyCardManager.KCM.AddKeyindex(_CodeIndex);
        base.PickUp();
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void SetCode(int CodeIndex)
    {
        //This sets the code
        _CodeIndex = CodeIndex;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}