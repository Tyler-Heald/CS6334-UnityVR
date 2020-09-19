using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube2Controller : MonoBehaviour
{
    bool shouldMove;

    // Start is called before the first frame update
    void Start()
    {
        shouldMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            transform.Rotate(0, 90 * Time.deltaTime, 0, Space.World);
        }
    }

    // Called on pointer down
    public void StartRotation(BaseEventData eventData)
    {
        if (IsLeftClick(eventData as PointerEventData))
        {
            shouldMove = true;
        }
    }
    
    // Called on pointer up
    public void StopRotation(BaseEventData eventData)
    {
        if (IsLeftClick(eventData as PointerEventData))
        {
            shouldMove = false;
        }
    }

    bool IsLeftClick(PointerEventData pointerEvent)
    {
        return pointerEvent != null && pointerEvent.button == PointerEventData.InputButton.Left;
    }
}
