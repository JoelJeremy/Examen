using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppableKeyCode : DropableItems
{
    public int _CodeIndex;

    public override GameObject DropItem()
    {
        DroppedKeyCard _Card = base.DropItem().GetComponent<DroppedKeyCard>();
        _Card.SetCode(_CodeIndex);

        return _Card.gameObject;
    }// Start is called before the first frame update

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}