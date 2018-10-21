using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

	public GameObject item
    {
        get
        {
            if (transform.childCount > 0){
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    // Teh recieving object
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            //  Get the static DragHandler object and the item, then set as a child of this transform
            DragHandler.itemBeingDragged.transform.SetParent(transform);
        }

    }
}
